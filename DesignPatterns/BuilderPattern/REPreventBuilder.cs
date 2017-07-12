using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 약속한 기능을 구체적으루 구현
    /// 상을 맺히는 기능 => 피사체의 일부분만 이미지로 맺히게
    /// 이미지를 수정하는 기능 => 적목을 일반적인 눈으로 변경
    /// </summary>
    class REPreventBuilder :PictureBuilder
    {
        const string RED_EYE = "RedEye";
        const string NORMAL_EYE = "NormalEye";
        const int MAX_LENGTH = 20;
        string subject;
        
        /// <summary>
        ///  상을 맺히는 기능
        /// </summary>
        /// <param name="subject"></param>
        public override void SetSubject(string subject)
        {
            if(subject.Length > MAX_LENGTH)
            {
                subject = subject.Substring(0, MAX_LENGTH);
            }
            this.subject = subject;
        }

        public override void Change()
        {
            string image = subject.Replace(RED_EYE, NORMAL_EYE);
            Picture = new Picture(subject, image);
        }
    }
}
