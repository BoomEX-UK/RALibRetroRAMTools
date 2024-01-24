using RALibRetroRAMTools;
using RALibRetroRAMTools.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;


public class RASector
{
    public string name = "";
    public long size = 0;

    public RASector(string name,long size)
    {
        this.name = name;
        this.size = size;
    }
}

public class RALibState
{
    // RASTATE Definitions
    public const string RASTATE_HEADER = "RASTATE";
    public const int RASTATE_VERSION = 1;

    public byte[] RASTATE_VALID = Encoding.ASCII.GetBytes(RASTATE_HEADER);
    public int padding = 0xCD;
    public Functions funcs = new Functions();
    public string filepath = "";

    public long filesize = 0;
    public string filesizeText = "";
    public string crc32 = "TBC";
    public Boolean valid = false;
    public string valid_reason = "";

    public byte[]? header;
    public List<RASector> sectors = new List<RASector>();

    private string convertFileSize( long fsize)
    {
        decimal asize = fsize;
        long kbsize = 1024;
        long mbsize = kbsize * 1024;
        long gbsize = mbsize * 1024;
        if (asize >= gbsize) return (asize / gbsize).ToString("0.#") + " GB";
        if (asize >= mbsize) return (asize / mbsize).ToString("0.#") + " MB";
        if (asize >= kbsize) return (asize / kbsize).ToString("0.#") + " KB";
        return asize + " B";
    }

    private void loadSectors()
    {
        int bPos = 8;
        while (bPos < filesize)
        {
            byte[]? bName = funcs.blockRead(filepath, bPos, 4);
            if (bName[0] == padding)
            {
                bPos += 1;
            }
            else
            {
                byte[]? bSize = funcs.blockRead(filepath, bPos + 4, 4);
                string sName = System.Text.Encoding.ASCII.GetString(bName);
                long sSize = BitConverter.ToUInt32(bSize, 0);
                if (sName != "END ")
                {
                    RASector rs = new RASector(sName, sSize);
                    sectors.Add(rs);
                }
                bPos += 8 + Convert.ToInt32(sSize);
            }
        }
    }

    public RALibState(string fPath)
    {
        filepath = fPath;
        Array.Resize(ref RASTATE_VALID, RASTATE_VALID.Length+1);
        RASTATE_VALID[RASTATE_VALID.Length-1] = RASTATE_VERSION;
        filesize = funcs.fileSize(filepath);
        filesizeText = convertFileSize(filesize);
        if (filesize > 24)
        {
            header = funcs.blockRead(filepath, 0, 8);
            if (header != null)
            {
                valid = header.SequenceEqual(RASTATE_VALID);
            }
            if (valid)
            {
                loadSectors();
            } else
            {
                valid_reason = "Header mismatch";
            }
        } else
        {
            valid_reason = "File below minimum size";
        }
    }
}

/*
namespace RALibRetroRAMTools.Classes
{
    internal class RAL_class
    {
    }
}
*/
