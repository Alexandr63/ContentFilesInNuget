using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LibA
{
    public class ClassLibA
    {
        public virtual void Exec()
        {
            Console.WriteLine($"ClassLibA.Exec {Assembly.GetAssembly(typeof(ClassLibA)).GetName()}");

            string dir = "fonts";
            bool hasFonts = Directory.Exists(dir) && Directory.GetFiles(dir).Any();

            Console.WriteLine($"Has fonts: {hasFonts}");
            if (Directory.Exists(dir))
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    Console.WriteLine($"\t{file}");
                }
            }
        }
    }
}