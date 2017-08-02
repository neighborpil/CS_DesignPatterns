using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class MyApp : EHApp
    {
        public override void InitInstance() // 재정의
        {
            Console.WriteLine("MyApp 초기화");

            base.InitInstance();
        }

        public override void ExitInstance() // 재정의
        {
            base.ExitInstance();

            Console.WriteLine("MyApp 해제");
        }

        protected override IView MakeView() //뷰 개체를 생성하는 메서드 구체적 구현
        {
            return new MyView();
        }
    }
}
