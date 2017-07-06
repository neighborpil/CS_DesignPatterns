using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HoLens : ITake
    {
        /// <summary>
        /// Itake에 약속된 기능을 구체적으로 구현
        /// </summary>
        public void Take()
        {
            Console.WriteLine("자연스럽다");
        }

        public void ManualFocus()
        {
            Console.WriteLine("사용자의 명령대로 초점을 잡다");
        }
    }
}
