using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HoCamera : Camera
    {
        /// <summary>
        /// 호환성 있는 렌즈를 장착하는 기능에 대한 구체적 구현
        /// </summary>
        /// <param name="itake">렌즈</param>
        /// <returns>장착 여부</returns>
        public override bool PutInLens(ITake itake)
        {
            // 호환성 있는 Ho렌즈 형식으로 참조연산
            HoLens holens = itake as HoLens;

            // 호환성 없을 때
            if (holens == null)
                return false;

            // 호환성 있는 렌즈일때 장착
            Lens = itake;

            return true;
        }

        public override bool TakeAPicture()
        {
            HoLens holens = Lens as HoLens;

            if (holens == null)
                return false;

            holens.ManualFocus();

            return base.TakeAPicture();
        }
    }
}
