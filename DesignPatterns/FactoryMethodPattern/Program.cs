using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            app.InitInstance();
            app.Run();
            app.ExitInstance();

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
