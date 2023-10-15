using System.IO;

namespace UnRenCS
{
    internal class Base64Codes
    {
        public static readonly string unpackCode = "";
        public static readonly string decompileCode = "";
        public static readonly string consoleCode = "";
        public static readonly string quickCode = "";
        public static readonly string skipCode = "";
        public static readonly string rollbackCode = "";

        static Base64Codes()
        {
            using (StreamReader Base64 = new StreamReader("Base64strings.txt"))
            {
                unpackCode = Base64.ReadLine();
                decompileCode = Base64.ReadLine();
                consoleCode = Base64.ReadLine();
                quickCode = Base64.ReadLine();
                skipCode = Base64.ReadLine();
                rollbackCode = Base64.ReadLine();
            }
        }
    }
}
