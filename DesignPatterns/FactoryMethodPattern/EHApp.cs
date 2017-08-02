using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    abstract class EHApp //뼈대를 제공하는 추상 클래스
    {
        protected IView MainView { get; set; }

        public virtual void InitInstance()
        {
            MainView = MakeView(); // 뷰 개체를 생성
        }

        public virtual void Run()
        {
            MainView.Show();
        }

        public virtual void ExitInstance()
        {
            MainView = null;
        }

        protected abstract IView MakeView(); // 뷰 개체를 생성하는 메서드 약속
    }
}
