using System;
using System.Reflection;
using LibB;

namespace LibC
{
    public class ClassLibC : ClassLibB
    {
        public override void Exec()
        {
            Console.WriteLine($"ClassLibC.Exec {Assembly.GetAssembly(typeof(ClassLibC)).GetName()}");

            base.Exec();
        }
    }
}