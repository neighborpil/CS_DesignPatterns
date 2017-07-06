using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Tester
    {
        IMakeCamera[] factories = new IMakeCamera[2];

        public Tester()
        {
            factories[0] = new EvDayFactory();
            factories[1] = new HoDayFactory();
        }

        /// <summary>
        /// 카메라와 렌즈의 호환성 테스트
        /// </summary>
        /// <param name="camera">카메라</param>
        /// <param name="lens">렌즈</param>
        private void TestCase(Camera camera, ITake lens)
        {
            Console.WriteLine("테스트");

            if(camera.PutInLens(lens) == false)
                Console.WriteLine("카메라에 렌즈가 장착 되지 않음");

            if(camera.TakeAPicture() == false)
                Console.WriteLine("사진이 찍히지 않았습니다");
        }

        public void Test()
        {
            //직접 카메라와 렌즈를 생성하여 호환성 테스트
            TestDirect();

            //팩토리를 통해 생성하여 호환성 테스트
            TestUsingFactory();
        }

        private void TestDirect()
        {
            Camera camera = new EvCamera();

            ITake lens = new HoLens();

            // 호환성 테스트
            TestCase(camera, lens);
        }

        private void TestUsingFactory()
        {
            Camera camera = null;

            ITake lens = null;

            foreach (IMakeCamera factory in factories)
            {
                camera = factory.MakeCamera();
                lens = factory.MakeLens();

                // 호환성 테스트
                TestCase(camera, lens);
            }
        }
    }
}
