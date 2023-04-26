using System;
using System.Collections.Generic;
using System.Reflection;
using LibB;

namespace LibC
{
    public class ClassLibC : ClassLibB
    {
        public virtual List<string> Exec()
        {
            Console.WriteLine($"ClassLibC.Exec {Assembly.GetAssembly(typeof(ClassLibC)).GetName()}");

            return base.Exec();
        }
    }
}