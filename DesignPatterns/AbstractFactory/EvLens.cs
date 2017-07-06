using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class EvLens : ITake
    {
        /// <summary>
        /// Itake에 약속된 기능을 구체적으로 구현
        /// </summary>
        public void Take()
        {
            Console.WriteLine("부드럽다");
        }

        public void AutoFocus()
        {
            Console.WriteLine("자동 초점을 조절하다");
        }
    }
}
