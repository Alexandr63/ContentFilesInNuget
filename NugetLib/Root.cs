using System.IO;
using System;

namespace NugetLib
{
    public class Root
    {
        public static void Test()
        {
            string dir = "fonts";
            bool hasFonts = Directory.Exists(dir) && Directory.GetFiles(dir).Length == 2;

            Console.WriteLine($"Has fonts: {hasFonts}");
        }
    }
}