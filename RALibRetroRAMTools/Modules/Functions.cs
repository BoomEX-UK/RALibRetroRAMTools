using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RALibRetroRAMTools.Modules
{
    public class Functions
    {
        public long fileSize(string filePath)
        {
            return new System.IO.FileInfo(filePath).Length;
        }

        public byte[]? blockRead(string filePath, int blockSize)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] block = new byte[blockSize];
            if (stream.Read(block, 0, blockSize) > 0)
            {  
                stream.Close();
                return block;
            }
            stream.Close();
            return null;
        }
    }
}
