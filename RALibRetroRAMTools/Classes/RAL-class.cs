using RALibRetroRAMTools.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;


public class RALibState
{
    public Functions funcs;
    public string filepath = "";
    public long filesize = 0;
    public string crc32 = "";
    public bool ready = false;
    public byte[]? header;

    void Start( string fPath )
    {
        filepath = fPath;
        filesize = funcs.fileSize(filepath);
        header = funcs.blockRead(filepath, 11);
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
