using System.Threading.Tasks;
using LibC;

namespace Consumer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ClassLibC test = new ClassLibC();
            test.Exec();
        }
    }
}