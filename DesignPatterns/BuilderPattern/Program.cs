using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
[BuilderPattern]

- 개체를 생성하는 방법이 목적에 따라 다양한 경우에 사용
- 목적에 따른 개체를 생성하는 과정에 대한 약속과 
  각 과정에서 수행할 구체적인 알고리즘을 분리하여 개체를 생성
- 빌더 : 추상클래스로 개체를 생성하는 과정들을 약속
- 빌더를 기반으로 파생한 클래스 : 생성과정들에 대해 구체적으루 구현
>> 이렇게 하면 사용하는 곳에서는 서로 다른 구조를 갖는 개체를 같은 방법으로 생성 가능

#클래스 디자인
1. 카메라
 - 사진을 찍는 기능, 효과를 주는 기능(효과를 주는 부분은 사진 빌더를 통해 수행)
 - 카메라는 디렉터 역할 Camera이름의 클래스로 구현
2. 사진(Picture) : 카메라를 통해 사용자가 얻고자 하는 개체
3. 사진 빌더
 - 빛을 모아서 피사체를 상으로 맺히는 기능
 - 이미지를 수정하는 기능
 - PictureBuilder : 위의 기능을 약속한 추상클래스
 - SmoothBuilder : 낮에 사용하는 빌더
 - REPreventBuilder : 밤에 사용하는 빌더

*/
namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera camera = new Camera();
            camera.PressAShutter("길 마당 RedEyeSharpBody 집 산", true);

            Console.WriteLine(camera.MyPicture.Image);

            camera.PressAShutter("길 마당 RedEyeSharpBody 집 산", false);

            Console.WriteLine(camera.MyPicture.Image);

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
