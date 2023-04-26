using System;
using System.Collections.Generic;
using System.Reflection;
using LibA;

namespace LibB
{
    public class ClassLibB : ClassLibA
    {
        public virtual List<string> Exec()
        {
            Console.WriteLine($"ClassLibB.Exec {Assembly.GetAssembly(typeof(ClassLibB)).GetName()}");

            return base.Exec();
        }
    }
}