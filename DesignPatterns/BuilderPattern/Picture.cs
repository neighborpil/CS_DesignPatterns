using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 피사체와 이에 대한 이미지를 갖는 형식으로 정의
    /// </summary>
    class Picture
    {
        public static readonly Picture EmptyPicture;

        static Picture()
        {
            EmptyPicture = new Picture(string.Empty, string.Empty); //객체 하나만 생성
        }

        public string Subject { get; private set; }
        public string Image { get; private set; }

        public Picture(string subject, string image)
        {
            Subject = subject;
            Image = image;
        }

    }
}
