using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Tester tester = new Tester();
            tester.Test();

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
