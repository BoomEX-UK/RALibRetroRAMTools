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

        public byte[]? blockRead(string filePath, int startpos, int blockSize)
        {
            try
            {
                FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                byte[] block = new byte[blockSize];
                stream.Position = startpos;
                if (stream.Read(block, 0, blockSize) > 0)
                {
                    stream.Close();
                    return block;
                }
                stream.Close();
            }
            catch (UnauthorizedAccessException ex)
            {
                return null;
            }
            catch (FileNotFoundException ex)
            {
                return null;
            }
            catch (IOException ex)
            {
                return null;
            }
            return null;
        }
    }
}
