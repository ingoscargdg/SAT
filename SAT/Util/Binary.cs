using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.Common
{
    public static class Binary
    {
        public static int GetIntegerSize(BinaryReader binReader)
        {
            byte bt = 0;
            byte lowbyte = 0x00;
            byte highbyte = 0x00;
            int count = 0;
            bt = binReader.ReadByte();
            if (bt != 0x02)		//expect integer
                return 0;
            bt = binReader.ReadByte();

            if (bt == 0x81)
                count = binReader.ReadByte();	// data size in next byte
            else
                if (bt == 0x82)
            {
                highbyte = binReader.ReadByte(); // data size in next 2 bytes
                lowbyte = binReader.ReadByte();
                byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
                count = BitConverter.ToInt32(modint, 0);
            }
            else
            {
                count = bt;     // we already have the data size
            }
            while (binReader.ReadByte() == 0x00)
            {	//remove high order zeros in data
                count -= 1;
            }
            binReader.BaseStream.Seek(-1, SeekOrigin.Current);
            //last ReadByte wasn't a removed zero, so back up a byte
            return count;
        }

        public static bool CompareBytearrays(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;
            int i = 0;
            foreach (byte c in a)
            {
                if (c != b[i])
                    return false;
                i++;
            }
            return true;
        }
    }
}
