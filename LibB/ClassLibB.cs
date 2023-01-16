using System;
using System.Reflection;
using LibA;

namespace LibB
{
    public class ClassLibB : ClassLibA
    {
        public override void Exec()
        {
            Console.WriteLine($"ClassLibB.Exec {Assembly.GetAssembly(typeof(ClassLibB)).GetName()}");

            base.Exec();
        }
    }
}