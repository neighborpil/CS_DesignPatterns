using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class SmoothBuilder : PictureBuilder
    {
        const string SHARP = "Sharp";
        const string SMOOTH = "Smooth";

        /// <summary>
        /// 원본 피사체
        /// </summary>
        string subject;

        /// <summary>
        /// 상을 맺히는 기능
        /// </summary>
        /// <param name="subject"></param>
        public override void SetSubject(string subject)
        {
            this.subject = subject;
            Picture = new Picture(subject, subject);
        }

        /// <summary>
        /// 이미지를 수정하는 기능
        /// </summary>
        public override void Change()
        {
            string image = subject.Replace(SHARP, SMOOTH);
            Picture = new Picture(subject, image);
        }
    }
}
