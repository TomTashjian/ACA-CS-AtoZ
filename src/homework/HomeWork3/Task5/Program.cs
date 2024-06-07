using System.Diagnostics.CodeAnalysis;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit and Explicit conversions between different types

            #region bool
            bool bool1 = true;

            // bool to byte
            // byte iByte1 = bool1; // Error
            // byte exByte1 = (byte)bool1; // Error

            // bool to sbyte
            // sbyte iSByte1 = bool1; // Error
            // sbyte exSByte1 = (sbyte)bool1; // Error

            // bool to short
            // short iShort1 = bool1; // Error
            // short exShort1 = (short)bool1; // Error

            // bool to ushort
            // ushort iUShort1 = bool1; // Error
            // ushort exUShort1 = (ushort)bool1; // Error

            // bool to int
            // int iint6 = bool1; // Error
            // int exint6 = (int)bool1; // Error

            // bool to uint
            // uint iUint6 = bool1; // Error
            // uint exUint6 = (uint)bool1; // Error

            // bool to nint
            // nint iNint6 = bool1; // Error
            // nint exNint6 = (nint)bool1; // Error

            // bool to nuint
            // nuint iNUint6 = bool1; // Error
            // nuint exNUint6 = (nuint)bool1; // Error

            // bool to long
            // long iLong1 = bool1; // Error
            // long exLong1 = (long)bool1; // Error

            // bool to ulong
            // ulong iULong1 = bool1; // Error
            // ulong exLong1 = (ulong)bool1; // Error

            // bool to float
            // float iFloat1 = bool1; // Error
            // float exFloat1 = (float)bool1; // Error

            // bool to double
            // double iDouble1 = bool1; // Error
            // double exDouble1 = (double)bool1; // Error

            // bool to decimal
            // decimal iDecimal1 = bool1; // Error
            // decimal exDecimal1 = (decimal)bool1; // Error

            // bool to char
            // char iChar1 = bool1; // Error
            // char exChar1 = (char)bool1; // Error

            // bool to string
            // string iString1 = bool1; // Error
            // string exString1 = (string)bool1; // Error

            // bool to object
            object iObj1 = bool1;
            object exObj1 = (object)bool1;

            #endregion bool

            #region byte
            byte byte2 = 255;

            // byte to bool
            // bool iBool2 = byte2; // Error
            // bool exBoo2 = (bool)byte2; // Error

            // byte to sbyte
            // sbyte iSByte2 = byte2; // Error
            sbyte exSByte2 = (sbyte)byte2;

            // byte to short
            short iShort2 = byte2;
            short exShprt2 = (short)byte2;

            // byte to ushort
            ushort iUShort2 = byte2;
            ushort exUShort2 = (ushort)byte2;

            // byte to int
            int iInt2 = byte2;
            int exInt2 = (int)byte2;

            // byte to uint
            uint iUInt2 = byte2;
            uint exUInt2 = (uint)byte2;

            // byte to nint
            nint iNInt2 = byte2;
            nint exNInt2 = (nint)byte2;

            // byte to nuint
            nuint iNUInt2 = byte2;
            nuint exNUInt2 = (nuint)byte2;

            // byte to long
            long iLong2 = byte2;
            long exLong2 = (long)byte2;

            // byte to ulong
            ulong iULong2  = byte2;
            ulong exULong2 = (ulong)byte2;

            // byte to float
            float iFloat2 = byte2;
            float exFloat2 = (float)byte2;
            
            // byte to double
            double iDouble2 = byte2;
            double exDouble2 = (double)byte2;
            
            // byte to decimal
            decimal iDecimal2 = byte2;
            decimal exDecimal2 = (decimal)byte2;

            // byte to char
            // char iChar2 = byte2; // Error
            char exChar2 = (char)byte2;
            Console.WriteLine($"explicit conversion from byte byte2 = {byte2} to char exChar2 = {exChar2}");

            // byte to string
            // string iString2 = byte2; // Error
            // string exString2 = (string)byte2; // Error

            // byte to object
            object iObj2 = byte2; // No error
            object exObj2 = (object)byte2; // No error

            #endregion byte

            #region sbyte
            sbyte sbyte3 = -1;

            // sbyte to bool
            // bool iBool3 = sbyte3; // Error
            // bool exBool3 = (bool)sbyte3; // Error
            
            // sbyte to byte
            // byte iByte3 = sbyte3; // Error
            // byte exByte3 = (sbyte)sbyte3; // Error

            // sbyte to short
            short iShort3 = sbyte3;
            short exShort3 = (short)sbyte3;

            // sbyte to ushort
            // ushort iUShort3 = sbyte3; // Error
            ushort exUShort3 = (ushort)sbyte3;

            // sbyte to int
            int iInt3 = sbyte3;
            int exInt3 = (int)sbyte3;

            // sbyte to uint
            //uint iUInt3 = sbyte3; // Error
            uint exUInt3 = (uint)sbyte3;

            // sbyte to nint
            nint iNInt3 = sbyte3;
            nint exNInt3 = (nint)sbyte3;

            // sbyte to nuint
            // nuint iNUInt3 = sbyte3; // Error
            nuint exNUInt3 = (nuint)sbyte3;

            // sbyte to long
            long iLong3 = sbyte3;
            long exLong3 = (long)sbyte3;

            // sbyte to ulong
            // ulong iULong3 = sbyte3; // Error
            ulong exULong3 = (ulong)sbyte3;

            // sbyte to float
            float iFloat3 = sbyte3;
            float exFloat3 = (float)sbyte3;

            // sbyte to double
            double iDouble3 = sbyte3;
            double exDouble3 = (double)sbyte3;

            // sbyte to decimal
            decimal iDecimal3 = sbyte3;
            decimal exDecimal3 = (decimal)sbyte3;

            // sbyte to char
            // char iChar3 = sbyte3; // Error
            char exChar3 = (char)sbyte3;

            // sbyte to string
            // string iString3 = sbyte3; // Error
            // string exString3 = (string)sbyte3; // Error

            // sbyte to object
            object iObj3 = sbyte3;
            object exObj3 = (object)sbyte3;

            #endregion sbyte

            #region short
            short short4 = 0;

            // short to bool
            // bool iBool4 = short4; // Error
            // bool exBool4 = (bool)short4; // Error

            // short to byte
            short4 = byte.MaxValue + 2;
            // byte iByte4 = short4; // Error
            byte exByte4 = (byte)short4;
            Console.WriteLine($"explicit conversion from short short4 = {short4} to byte exByte4 = {exByte4}");
            Console.WriteLine("binary representation of short4 = " + Convert.ToString(short4, 2));
            Console.WriteLine("binary representation of exByte4 = " + Convert.ToString(exByte4, 2));

            // short to sbyte
            short4 = sbyte.MaxValue + 2;
            // sbyte iSByte4 = short4; // Error
            sbyte exSByte4 = (sbyte)short4;
            Console.WriteLine($"explicit conversion from short short4 = {short4} to byte exSByte4 = {exSByte4}");
            Console.WriteLine("binary representation of short4 = " + Convert.ToString(short4, 2));
            Console.WriteLine("binary representation of exSByte4 = " + Convert.ToString(exSByte4, 2)); // using short to represent sbyte, because overload for sbyte is not available
            
            // short to ushort
            short4 = -2;
            // ushort iUShort4 = short4; // Error
            ushort exUShort4 = (ushort)short4;
            Console.WriteLine($"explicit conversion from short short4 = {short4} to ushort exUShort4 = {exUShort4}");
            Console.WriteLine("binary representation of short4 = " + Convert.ToString(short4, 2));
            Console.WriteLine("binary representation of exUShort4 = " + Convert.ToString(exUShort4, 2));
            
            // short to int
            int iInt4 = short4;
            int exInt4 = (int)short4;

            // short to uint
            // uint iUInt4 = short4; // Error
            uint exUInt4 = (uint)short4;
            Console.WriteLine($"explicit conversion from short short4 = {short4} to uint exUInt4 = {exUInt4}");
            Console.WriteLine("binary representation of short4 = " + Convert.ToString(short4, 2));
            Console.WriteLine("binary representation of exUInt4 = " + Convert.ToString(exUInt4, 2));

            // short to nint
            nint iNInt4 = short4; // No error int both 32 and 64 bit platforms
            nint exNInt4 = (nint)short4; // No error int both 32 and 64 bit platforms

            // short to nuint
            // nuint iNUInt4  = short4; // Error
            nuint exNUInt4 = (nuint)short4;

            // short to long
            long iLong4 = short4;
            long exLong4 = (long)short4;

            // short to ulong
            // ulong iULong4 = short4; // Error
            ulong exULong4 = (ulong)short4;

            // short to float
            float iFloat4 = short4;
            float exFloat4 = (float)short4;

            // short to double
            double iDouble4 = short4;
            double exDouble4 = (double)short4;

            // short to decimal
            decimal iDecimal4 = short4;
            decimal exDecimal4 = (decimal)short4;

            // short to char
            short4 = 65;
            // char iChar4 = short4; // Error
            char exChar4 = (char)short4; // No error
            Console.WriteLine($"explicit conversion from short short4 = {short4} to char exChar4 = {exChar4}");

            // short to string
            // string iString4 = short4; // Error
            // string exString4 = (string)short4; // Error

            // short to object
            object iObj4 = short4; // No error
            object exObj4 = (object)short4; // No error

            #endregion

            #region ushort
            ushort ushort5 = 0;

            // ushort to bool
            // bool iBool5 = ushort5; // Error
            // bool exBool5 = (bool)ushort5; // Error

            // ushort to byte
            ushort5 = byte.MaxValue + 2;
            //byte iByte5 = ushort5; // Error
            byte exByte5 = (byte)ushort5;
            Console.WriteLine($"explicit conversion from ushort ushort5 = {ushort5} to byte exByte5 = {exByte5}");

            // ushort to sbyte
            ushort5 = sbyte.MaxValue + 2;
            // sbyte iSByte5 = ushort5; // Error
            sbyte exSByte5 = (sbyte)ushort5;
            Console.WriteLine($"explicit conversion from ushort ushort5 = {ushort5} to byte exSByte5 = {exSByte5}");
            Console.WriteLine("binary representation of ushort5 = " + Convert.ToString(ushort5, 2));
            Console.WriteLine("binary representation of exSByte5 = " + Convert.ToString(exSByte5, 2)); // using ushort to represent sbyte, because overload for sbyte is not available

            // ushort to short
            ushort5 = short.MaxValue + 2;
            // short iShort5 = ushort5; // Error
            short exShort5 = (short)ushort5;
            Console.WriteLine($"explicit conversion from ushort ushort5 = {ushort5} to short exShort5 = {exShort5}");
            Console.WriteLine("binary representation of ushort5 = " + Convert.ToString(ushort5, 2));
            Console.WriteLine("binary representation of exShort5 = " + Convert.ToString(exShort5, 2));

            // ushort to int
            int iInt5 = ushort5;
            int exInt5 = (int)ushort5;

            // ushort to uint
            uint iUInt5 = ushort5;
            uint exUInt5 = (uint)ushort5;

            // ushort to nint
            nint iNInt5 = ushort5; // No error int both 32 and 64 bit platforms
            nint exNInt5 = (nint)ushort5; // No error int both 32 and 64 bit platforms

            // ushort to nuint
            nuint iNUInt5  = ushort5;
            nuint exNUInt5 = (nuint)ushort5;

            // ushort to long
            long iLong5 = ushort5;
            long exLong5 = (long)ushort5;

            // ushort to ulong
            ulong iULong5 = ushort5;
            ulong exULong5 = (ulong)ushort5;

            // ushort to float
            float iFloat5 = ushort5;
            float exFloat5 = (float)ushort5;

            // ushort to double
            double iDouble5 = ushort5;
            double exDouble5 = (double)ushort5;

            // ushort to decimal
            decimal iDecimal5 = ushort5;
            decimal exDecimal5 = (decimal)ushort5;

            // ushort to char
            ushort5 = 65;
            // char iChar5 = ushort5; // Error
            char exChar5 = (char)ushort5;
            Console.WriteLine($"explicit conversion from ushort ushort5 = {ushort5} to char exChar5 = {exChar5}");

            // ushort to string
            // string iString5 = ushort5; // Error
            // string exString5 = (string)ushort5; // Error

            // ushort to object
            object iObj5 = ushort5;
            object exObj5 = (object)ushort5;

            #endregion ushort

            #region int
            int int6 = 0;

            // int to bool
            // bool iBool6 = int6; // Error
            // bool exBool6 = (bool)int6; // Error
            
            // int to byte
            int6 = byte.MaxValue + 2;
            // byte iByte6 = int6; // Error
            byte exByte6 = (byte)int6;
            Console.WriteLine($"explicit conversion from int int6 = {int6} to byte exByte6 = {exByte6}");
            Console.WriteLine("binary representation of int6 = " + Convert.ToString(int6, 2));
            Console.WriteLine("binary representation of exByte6 = " + Convert.ToString(exByte6, 2));

            // int to sbyte
            int6 = sbyte.MaxValue + 2;
            // sbyte iSByte6 = int6; // Error
            sbyte exSByte6 = (sbyte)int6;
            Console.WriteLine($"explicit conversion from int int6 = {int6} to byte exSByte6 = {exSByte6}");
            Console.WriteLine("binary representation of int6 = " + Convert.ToString(int6, 2));
            Console.WriteLine("binary representation of exSByte6 = " + Convert.ToString(exSByte6, 2)); // using ushort to represent sbyte, because overload for sbyte is not available

            // int to ushort
            int6 = ushort.MaxValue + 2;
            // ushort iShort6 = int6; // Error
            ushort exShort6 = (ushort)int6;
            Console.WriteLine($"explicit conversion from int int6 = {int6} to ushort exShort6 = {exShort6}");
            Console.WriteLine("binary representation of int6 = " + Convert.ToString(int6, 2));
            Console.WriteLine("binary representation of exShort6 = " + Convert.ToString(exShort6, 2));

            // int to ushort
            int6 = ushort.MaxValue + 2;
            // ushort iUShort6 = int6; // Error
            ushort exUShort6 = (ushort)int6;
            Console.WriteLine($"explicit conversion from int int6 = {int6} to ushort exUShort6 = {exUShort6}");
            Console.WriteLine("binary representation of int6 = " + Convert.ToString(int6, 2));
            Console.WriteLine("binary representation of exUShort6 = " + Convert.ToString(exUShort6, 2));

            // int to uint
            int6 = -2;
            // uint iUInt6 = int6; // Error
            uint exUInt6 = (uint)int6;
            Console.WriteLine($"explicit conversion from int int6 = {int6} to uint exUInt6 = {exUInt6}");
            Console.WriteLine("binary representation of int6 = " + Convert.ToString(int6, 2));
            Console.WriteLine("binary representation of exUInt6 = " + Convert.ToString(exUInt6, 2));

            // int to nint
            int6 = -2;
            nint iNInt6 = int6; // No error int both 32 and 64 bit platforms
            nint exNInt6 = (nint)int6; // No error int both 32 and 64 bit platforms

            // int to nuint
            int6 = -2;
            // nuint iNUInt6 = int6; // Error
            nuint exNUInt6 = (nuint)int6;
            Console.WriteLine($"explicit conversion from int int6 = {int6} to nuint exNUInt6 = {exNUInt6}");
            Console.WriteLine("hexadecimal representation of int6 = " + string.Format("0x{0:X}", int6));
            Console.WriteLine("hexadecimal representation of exNUInt6 = " + string.Format("0x{0:X}", exNUInt6));

            // int to long
            long iLong6 = int6; // No error
            long exLong6 = (long)int6; // No error

            // int to ulong
            int6 = int.MinValue;
            // ulong iULong6 = int6; // Error
            ulong exULong6 = (ulong)int6;
            Console.WriteLine($"explicit conversion from int int6 = {int6} to ulong exULong6 = {exULong6}");
            Console.WriteLine("hexadecimal representation of int6 = " + string.Format("0x{0:X}", int6));
            Console.WriteLine("hexadecimal representation of exULong6 = " + string.Format("0x{0:X}", exULong6));

            // in to float
            float iFloat6 = int6; // No error
            float exFloat6 = (float)int6; // No error

            // int to double
            double iDouble6 = int6; // No error
            double exDouble6 = (double)int6; // No error

            // int to decimal
            decimal iDecimal6 = int6; // No error
            decimal exDecimal6 = (decimal)int6; // No error

            // int to char
            int6 = 65;
            // char iChar6 = int6; // Error
            char exChar6 = (char)int6; // No error
            Console.WriteLine($"explicit conversion from int int6 = {int6} to char exChar6 = {exChar6}");

            // int to string
            // string iString6 = int6; // Error
            // string exString6 = (string)int6; // Error

            // int to object
            object iObj6 = int6; // No error
            object exObj6 = (object)int6; // No error

            #endregion int

            #region uint
            uint uint7 = 0;

            // uint to bool
            // bool iBool7 = uint7; // Error
            // bool exBool7 = (bool)uint7; // Error

            // uint to byte
            // byte iByte7 = uint7; // Error
            byte exByte7 = (byte)uint7;

            // uint to sbyte
            // sbyte iSByte7 = uint7; // Error
            sbyte exSByte7 = (sbyte)uint7;

            // uint to short
            // short iShort7 = uint7; // Error
             short exShort7 = (short)uint7;

            // uint to ushort
            // ushort iUShort7 = uint7; // Error
            ushort exUShort7 = (ushort)uint7;

            // uint to int
            // int iUInt7 = uint7; // Error
            int exUInt7 = (int)uint7;

            // uint to nint
            // nint iNInt7 = uint7; // Error
            nint exNInt7 = (nint)uint7;

            // uint to nuint
            nuint iNUInt7 = uint7;
            nuint exNUInt7 = (nuint)uint7;

            // uint to long
            long iLong7 = uint7; 
            long exLong7 = (long)uint7;

            // uint to ulong
            ulong iULong7 = uint7;
            ulong exULong7 = (ulong)uint7;

            // uint to float
            float iFloat7 = uint7;
            float exFloat7 = (float)uint7;

            // uint to double
            double iDouble7 = uint7;
            double exDouble7 = (double)uint7;

            // uint to decimal
            decimal iDecimal7 = uint7;
            decimal exDecimal7 = (decimal)uint7;

            // uint to char
            // char iChar7 = uint7; // Error
            char exChar7 = (char)uint7;

            // uint to string
            // string iString7 = uint7; // Error
            // string exString7 = (string)uint7; // Error

            // uint to object
            object iObj7 = uint7;
            object exObj7 = (object)uint7;

            #endregion uint

            #region nint
            nint nint8= 0;

            // nint to bool
            // bool iBool8 = nint8; // Error
            // bool exBool8 = (bool)nint8; // Error

            // nint to byte
            // byte iByte8 = nint8; // Error
            byte exByte8 = (byte)nint8;

            // nint to sbyte
            // sbyte iSByte8 = nint8; // Error
            sbyte exSByte8 = (sbyte)nint8;

            // nint to short
            // short iShort8 = nint8; // Error
            short exShort8 = (short)nint8;

            // nint to ushort
            // ushort iUShort8 = nint8; // Error
            ushort exUShort8 = (ushort)nint8;

            // nint to int
            // int iInt8 = nint8; // Error
            int exInt8 = (int)nint8; //Error

            // nint to uint
            // uint iUInt8 = nint8; // Error
            uint exUInt8 = (uint)nint8;

            // nint to nuint
            // nuint iNUInt8 = nint8; // Error
            nuint exNUInt8 = (nuint)nint8;

            // nint to long
            long iLong8 = nint8;
            long exLong8 = (long)nint8;

            // nint to ulong
            // ulong iULong8 = nint8; // Error
            ulong exULong8 = (ulong)nint8;

            // nint to float
            float iFloat8 = nint8;
            float exFloat8 = (float)nint8;

            // nint to double
            double iDouble8 = nint8;
            double exDouble8 = (double)nint8;

            // nint to decimal
            decimal iDecimal8 = nint8;
            decimal exDecimal8 = (decimal)nint8;

            // nint to char
            // char iChar8 = nint8; // Error
            char exChar8 = (char)nint8;

            // nint to string
            // string iString8 = nint8; // Error
            // string exString8 = (string)nint8; // Error

            // nint to object
            object iObj8 = nint8;
            object exObj8 = (object)nint8;

            #endregion nint

            #region nuint
            nuint nuint9 = 0;

            // bool iBool9 = nuint9; // Error
            // bool exBool9 = (bool)nuint9; // Error

            // byte iByte9 = nuint9; // Error
            byte exByte9 = (byte)nuint9;

            // sbyte iSByte9 = nuint9; // Error
            sbyte exSByte9 = (sbyte)nuint9;

            // short iShort9 = nuint9; // Error
            short exShort9 = (short)nuint9;

            // ushort iUShort9 = nuint9; // Error
            ushort exUShort9 = (ushort)nuint9;

            // int iInt9 = nuint9; // Error
            int exInt9 = (int)nuint9;

            // uint iUInt9 = nuint9; // Error
            uint exUInt9 = (uint)nuint9;

            // nint iNInt9 = nuint9; // Error
            nint exNInt9 = (nint)nuint9;

            // long iLong9 = nuint9; // Error
            long exLong9 = (long)nuint9;

            ulong iULong9 = nuint9;
            ulong exULong9 = (ulong)nuint9;

            float iFloat9 = nuint9;
            float exFloat9 = (float)nuint9;

            double iDouble9 = nuint9;
            double exDouble9 = (double)nuint9;

            decimal iDecimal9 = nuint9;
            decimal exDecimal9 = (decimal)nuint9;

            // char iChar9 = nuint9; // Error
            char exChar9 = (char)nuint9;

            // string iString9 = nuint9; // Error
            // string exString9 = (string)nuint9; // Error

            object iObj9 = nuint9;
            object exObj9 = (object)nuint9;

            #endregion nuint

            #region long
            long long10 = 0;

            // bool iBool10 = long10; // Error
            // bool exBool10 = (bool)long10; // Error

            // byte iByte10 = long10; // Error
            byte exByte10 = (byte)long10;

            // sbyte iSByte10 = long10; // Error
            sbyte exSByte10 = (sbyte)long10;

            // short iShort10 = long10; // Error
            short exShort10 = (short)long10;

            // ushort iUShort10 = long10; // Error
            ushort exUShort10 = (ushort)long10;

            // int iInt10 = long10; // Error
            int exInt10 = (int)long10;

            // uint iUInt10 = long10; // Error
            uint exUInt10 = (uint)long10;

            // nint iNInt10 = long10; // Error
            nint exNInt10 = (nint)long10;

            // nuint iNUInt10 = long10; // Error
            nuint exNUInt10 = (nuint)long10;

            // long iLong10 = long10; // Same type
            // long exLong10 = (long)long10; // Same type

            // ulong iULong10 = long10; // Error
            ulong exULong10 = (ulong)long10;

            float iFloat10 = long10;
            float exFloat10 = (float)long10;

            double iDouble10 = long10;
            double exDouble10 = (double)long10;

            decimal iDecimal10 = long10;
            decimal exDecimal10 = (decimal)long10;

            // char iChar10 = long10; // Error
            char exChar10 = (char)long10;

            // string iString10 = long10; // Error
            // string exString10 = (string)long10; // Error

            object iObj10 = long10;
            object exObj10 = (object)long10;

            #endregion long

            #region ulong
            ulong ulong11 = 0;

            // bool iBool11 = ulong11; // Error
            // bool exBool11 = (bool)ulong11; // Error

            // byte iByte11 = ulong11; // Error
            byte exByte11 = (byte)ulong11;

            // sbyte iSByte11 = ulong11; // Error
            sbyte exSByte11 = (sbyte)ulong11;

            // short iShort11 = ulong11; // Error
            short exShort11 = (short)ulong11;

            // ushort iUShort11 = ulong11; // Error
            ushort exUShort11 = (ushort)ulong11;

            // int iInt11 = ulong11; // Error
            int exInt11 = (int)ulong11;

            // uint iUInt11 = ulong11; // Error
            uint exUInt11 = (uint)ulong11;

            // nint iNInt11 = ulong11; // Error
            nint exNInt11 = (nint)ulong11;

            // nuint iNUInt11 = ulong11; // Error
            nuint exNUInt11 = (nuint)ulong11;

            // long iLong11 = ulong11; // Error
            long exLong11 = (long)ulong11;

            ulong iULong11 = ulong11; // Same type
            ulong exULong11 = (ulong)ulong11; // Same type

            float iFloat11 = ulong11;
            float exFloat11 = (float)ulong11;

            double iDouble11 = ulong11;
            double exDouble11 = (double)ulong11;

            decimal iDecimal11 = ulong11;
            decimal exDecimal11 = (decimal)ulong11;

            // char iChar11 = ulong11; // Error
            char exChar11 = (char)ulong11;

            // string iString11 = ulong11; // Error
            // string exString11 = (string)ulong11; // Error

            object iObj11 = ulong11;
            object exObj11 = (object)ulong11;

            #endregion ulong

            #region float
            float float12 = 0.0f;

            // bool iBool12 = float12; // Error
            // bool exBool12 = (bool)float12; // Error

            // byte iByte12 = float12; // Error
            byte exByte12 = (byte)float12;

            // sbyte iSByte12 = float12; // Error
            sbyte exSByte12 = (sbyte)float12;

            // short iShort12 = float12; // Error
            short exShort12 = (short)float12;

            // ushort iUShort12 = float12; // Error
            ushort exUShort12 = (ushort)float12;

            // int iInt12 = float12; // Error
            int exInt12 = (int)float12;

            // uint iUInt12 = float12; // Error
            uint exUInt12 = (uint)float12;

            // nint iNInt12 = float12; // Error
            nint exNInt12 = (nint)float12;

            // nuint iNUInt12 = float12; // Error
            nuint exNUInt12 = (nuint)float12;

            // long iLong12 = float12; // Error
            long exLong12 = (long)float12;

            // ulong iULong12 = float12; // Error
            ulong exULong12 = (ulong)float12; // Error

            float iFloat12 = float12; // Same type
            float exFloat12 = (float)float12; // Same type

            double iDouble12 = float12;
            double exDouble12 = (double)float12;

            // decimal iDecimal12 = float12; // Error (interesting)
            decimal exDecimal12 = (decimal)float12;

            // char iChar12 = float12; // Error
            char exChar12 = (char)float12;

            // string iString12 = float12; // Error
            // string exString12 = (string)float12; // Error

            object iObj12 = float12;
            object exObj12 = (object)float12;

            #endregion float

            #region double
            double double13 = 0.0;

            // bool iBool13 = double13; // Error
            // bool exBool13 = (bool)double13; // Error

            // byte iByte13 = double13; // Error
            byte exByte13 = (byte)double13;

            // sbyte iSByte13 = double13; // Error
            sbyte exSByte13 = (sbyte)double13;

            // short iShort13 = double13; // Error
            short exShort13 = (short)double13;

            // ushort iUShort13 = double13; // Error
            ushort exUShort13 = (ushort)double13;

            // int iInt13 = double13; // Error
            int exInt13 = (int)double13;

            // uint iUInt13 = double13; // Error
            uint exUInt13 = (uint)double13;

            // nint iNInt13 = double13; // Error
            nint exNInt13 = (nint)double13;

            // nuint iNUInt13 = double13; // Error
            nuint exNUInt13 = (nuint)double13;

            // long iLong13 = double13; // Error
            long exLong13 = (long)double13;

            // ulong iULong13 = double13; // Error
            ulong exULong13 = (ulong)double13; // Error

            // float iFloat13 = double13; // Error
            float exFloat13 = (float)double13; 

            double iDouble13 = double13; // Same type
            double exDouble13 = (double)double13; // Same type

            // decimal iDecimal13 = double13; // Error (interesting)
            decimal exDecimal13 = (decimal)double13;

            // char iChar13 = double13; // Error
            char exChar13 = (char)double13;

            // string iString13 = double13; // Error
            // string exString13 = (string)double13; // Error

            object iObj13 = double13;
            object exObj13 = (object)double13;

            #endregion double

            #region decimal
            decimal decimal14 = 0.0m;

            // bool iBool14 = decimal14; // Error
            // bool exBool14 = (bool)decimal14; // Error

            // byte iByte14 = decimal14; // Error
            byte exByte14 = (byte)decimal14;

            // sbyte iSByte14 = decimal14; // Error
            sbyte exSByte14 = (sbyte)decimal14;

            // short iShort14 = decimal14; // Error
            short exShort14 = (short)decimal14;

            // ushort iUShort14 = decimal14; // Error
            ushort exUShort14 = (ushort)decimal14;

            // int iInt14 = decimal14; // Error
            int exInt14 = (int)decimal14;

            // uint iUInt14 = decimal14; // Error
            uint exUInt14 = (uint)decimal14;

            // nint iNInt14 = decimal14; // Error
            nint exNInt14 = (nint)decimal14;

            // nuint iNUInt14 = decimal14; // Error
            nuint exNUInt14 = (nuint)decimal14;

            // long iLong14 = decimal14; // Error
            long exLong14 = (long)decimal14;

            // ulong iULong14 = decimal14; // Error
            ulong exULong14 = (ulong)decimal14; // Error

            // float iFloat14 = decimal14; // Error
            float exFloat14 = (float)decimal14;

            // double iDouble14 = decimal14; // Error
            double exDouble14 = (double)decimal14;

            decimal iDecimal14 = decimal14; // Same type
            decimal exDecimal14 = (decimal)decimal14; // Same type

            // char iChar14 = decimal14; // Error
            char exChar14 = (char)decimal14;

            // string iString14 = decimal14; // Error
            // string exString14 = (string)decimal14; // Error

            object iObj14 = decimal14;
            object exObj14 = (object)decimal14;

            #endregion decimal

            #region char
            char char15 = 'A';

            // bool iBool15 = char15; // Error
            // bool exBool15 = (bool)char15; // Error

            // byte iByte15 = char15; // Error
            byte exByte15 = (byte)char15;

            // sbyte iSByte15 = char15; // Error
            sbyte exSByte15 = (sbyte)char15;

            // short iShort15 = char15; // Error
            short exShort15 = (short)char15;

            ushort iUShort15 = char15;
            ushort exUShort15 = (ushort)char15;

            int iInt15 = char15;
            int exInt15 = (int)char15;

            uint iUInt15 = char15;
            uint exUInt15 = (uint)char15;

            nint iNInt15 = char15;
            nint exNInt15 = (nint)char15;

            nuint iNUInt15 = char15;
            nuint exNUInt15 = (nuint)char15;

            long iLong15 = char15;
            long exLong15 = (long)char15;

            ulong iULong15 = char15;
            ulong exULong15 = (ulong)char15;

            float iFloat15 = char15;
            float exFloat15 = (float)char15;

            double iDouble15 = char15;
            double exDouble15 = (double)char15;

            decimal iDecimal15 = char15;
            decimal exDecimal15 = (decimal)char15;

            char iChar15 = char15; // Same type
            char exChar15 = (char)char15; // Same type

            // string iString15 = char15; // Error (interesting)
            // string exString15 = (string)char15; // Error (interesting)

            object iObj15 = char15;
            object exObj15 = (object)char15;

            #endregion char

            #region string
            string string16 = "Hello";

            //bool iBool16 = string16; // Error
            //bool exBool16 = (bool)string16; // Error

            //byte iByte16 = string16; // Error
            //byte exByte16 = (byte)string16; // Error

            //sbyte iSByte16 = string16; // Error
            //sbyte exSByte16 = (sbyte)string16; // Error

            //short iShort16 = string16; // Error
            //short exShort16 = (short)string16; // Error

            //ushort iUShort16 = string16; // Error
            //ushort exUShort16 = (ushort)string16; // Error

            //int iInt16 = string16; // Error
            //int exInt16 = (int)string16; // Error

            //uint iUInt16 = string16; // Error
            //uint exUInt16 = (uint)string16; // Error

            //nint iNInt16 = string16; // Error
            //nint exNInt16 = (nint)string16; // Error

            //nuint iNUInt16 = string16; // Error
            //nuint exNUInt16 = (nuint)string16; // Error

            //long iLong16 = string16; // Error
            //long exLong16 = (long)string16; // Error

            //ulong iULong16 = string16; // Error
            //ulong exULong16 = (ulong)string16; // Error

            //float iFloat16 = string16; // Error
            //float exFloat16 = (float)string16; // Error

            //double iDouble16 = string16; // Error
            //double exDouble16 = (double)string16; // Error

            //decimal iDecimal16 = string16; // Error
            //decimal exDecimal16 = (decimal)string16; // Error

            //char iChar16 = string16; // Error
            //char exChar16 = (char)string16; // Error

            string iString16 = string16; // Same type
            string exString16 = (string)string16; // Same type

            object iObj16 = string16;
            object exObj16 = (object)string16;

            #endregion string

            #region object
            object obj17 = new object(); ;

            //bool iBool17 = obj17; // Error
            bool exBool17 = (bool)obj17;

            //byte iByte17 = obj17; // Error
            byte exByte17 = (byte)obj17;

            //sbyte iSByte17 = obj17; // Error
            sbyte exSByte17 = (sbyte)obj17;

            //short iShort17 = obj17; // Error
            short exShort17 = (short)obj17;

            //ushort iUShort17 = obj17; // Error
            ushort exUShort17 = (ushort)obj17;

            //int iInt17 = obj17; // Error
            int exInt17 = (int)obj17;

            //uint iUInt17 = obj17; // Error
            uint exUInt17 = (uint)obj17;

            //nint iNInt17 = obj17; // Error
            nint exNInt17 = (nint)obj17;

            //nuint iNUInt17 = obj17; // Error
            nuint exNUInt17 = (nuint)obj17;

            //long iLong17 = obj17; // Error
            long exLong17 = (long)obj17;

            //ulong iULong17 = obj17; // Error
            ulong exULong17 = (ulong)obj17;

            //float iFloat17 = obj17; // Error
            float exFloat17 = (float)obj17;

            //double iDouble17 = obj17; // Error
            double exDouble17 = (double)obj17;

            //decimal iDecimal17 = obj17; // Error
            decimal exDecimal17 = (decimal)obj17;

            //char iChar17 = obj17; // Error
            char exChar17 = (char)obj17;

            //string iString17 = obj17; // Error
            string exString17 = (string)obj17;

            object iObj17 = obj17; // Same type
            object exObj17 = (object)obj17; // Same type

            #endregion object
        }
    }
}
