using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Ionic.Zlib;

namespace Quazal
{
    public static class DataWriter
    {
        public static Random random = new Random();

        public static ulong MakeTimestamp()
        {
            return (ulong)new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;
        }
        
        public static bool ReadBool(Stream s)
        {
            return s.ReadByte() != 0;
        }

        public static byte ReadUint8(Stream s)
        {
            return (byte)s.ReadByte();
        }
        
        public static ushort ReadUint16(Stream s)
        {
            return (ushort)((byte)s.ReadByte() | ((byte)s.ReadByte() << 8));
        }

        public static ushort ReadUint16LE(Stream s)
        {
            return (ushort)(((byte)s.ReadByte() << 8) | (byte)s.ReadByte());
        }

        public static uint ReadUint32(Stream s)
        {
            return (uint)((byte)s.ReadByte() | 
                         ((byte)s.ReadByte() << 8) | 
                         ((byte)s.ReadByte() << 16) | 
                         ((byte)s.ReadByte() << 24));
        }

        public static ulong ReadUint64(Stream s)
        {
            return (ulong)((byte)s.ReadByte() | 
                          ((byte)s.ReadByte() << 8) | 
                          ((byte)s.ReadByte() << 16) |
                          ((byte)s.ReadByte() << 24) |
                          ((byte)s.ReadByte() << 32) |
                          ((byte)s.ReadByte() << 40) |
                          ((byte)s.ReadByte() << 48) |
                          ((byte)s.ReadByte() << 56));
        }

        public static float ReadFloat(Stream s)
        {
            byte[] b = new byte[4];
            s.Read(b, 0, 4);
            return BitConverter.ToSingle(b, 0);
        }

        public static double ReadDouble(Stream s)
        {
            byte[] b = new byte[8];
            s.Read(b, 0, 8);
            return BitConverter.ToDouble(b, 0);
        }

        public static string ReadString(Stream s)
        {
            string result = "";
            ushort len = ReadU16(s);
            for (int i = 0; i < len - 1; i++)
                result += (char)s.ReadByte();
            s.ReadByte();
            return result;
        }

    }
    
}