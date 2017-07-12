using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 추상클래스로 아래 기능들에 대한 약속을 함
    /// 빛을 모아 피사체를 이미지로 맺히는 역할
    /// 수정작업을 수행하는 역할
    /// </summary>
    abstract class PictureBuilder
    {
        public Picture Picture { get; protected set; }
        /// <summary>
        /// 상을 맺히는 기름
        /// </summary>
        /// <param name="subject"></param>
        public abstract void SetSubject(string subject);

        /// <summary>
        /// 이미지를 수정하는 기능
        /// </summary>
        public abstract void Change();
    }
}
