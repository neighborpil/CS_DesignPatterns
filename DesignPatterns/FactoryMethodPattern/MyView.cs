using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class MyView : IView
    {
        public MyView()
        {
            Console.WriteLine("MyView 개체 생성");
        }

        public void Show()
        {
            Console.WriteLine("메인뷰 활성화");
        }
    }
}
