using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// PressAShutter : 셔터를 누르면 피사체를 사진으로 만들어주는 기능
    /// 매개변수로 낮밤 구별 인자를 받아 상을 맺는다
    /// 수정(Change)한다
    /// </summary>
    class Camera
    {
        PictureBuilder[] builders = new PictureBuilder[2];

        public Picture MyPicture { get; private set; }

        public Camera()
        {
            builders[0] = new REPreventBuilder();
            builders[1] = new SmoothBuilder();

            MyPicture = Picture.EmptyPicture;
        }

        public void PressAShutter(string origin, bool night)
        {
            PictureBuilder pb = null;

            if (night)
                pb = builders[0]; //밤일 때
            else
                pb = builders[1]; //낮일 때

            pb.SetSubject(origin); //상을 맺힌다

            pb.Change(); //이미지를 수정한다

            MyPicture = pb.Picture;


        }
    }
}
