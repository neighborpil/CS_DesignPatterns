using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Camera
    {
        protected ITake Lens { get; set; }

        public Camera()
        {
            Lens = null;
        }

        /// <summary>
        /// 호환성 있는 렌즈를 장착하는 메서드 - 구체적 구현은 파생 클래스에서
        /// </summary>
        /// <param name="itake">렌즈</param>
        /// <returns></returns>
        public abstract bool PutInLens(ITake itake);

        public ITake GetOutLens()
        {
            ITake re = Lens;
            Lens = null;

            return re;
        }

        /// <summary>
        /// 사진을 찍는 가상 메서드
        /// </summary>
        /// <returns></returns>
        public virtual bool TakeAPicture()
        {
            if (Lens == null)
                return false;

            //렌즈에 상을 맺힌다
            Lens.Take();

            return true;
        }
    }
}
