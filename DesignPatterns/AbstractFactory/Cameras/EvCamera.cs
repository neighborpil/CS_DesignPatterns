using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class EvCamera : Camera
    {
        /// <summary>
        /// 호환성 있는 렌즈를 장착하는 기능에 대한 구체적 구현
        /// </summary>
        /// <param name="itake">렌즈</param>
        /// <returns>장착 여부</returns>
        public override bool PutInLens(ITake itake)
        {
            // 호환성 있는 Ev 렌즈 형식으로 참조 연산
            EvLens evlens = itake as EvLens;

            // 호환성 없는 렌즈일 때
            if (evlens == null)
                return false;

            // 호환성 있는 렌즈일 때 장착
            Lens = itake;

            return true;
        }

        public override bool TakeAPicture()
        {
            EvLens evlens = Lens as EvLens;

            if (evlens == null)
                return false;

            evlens.AutoFocus();

            return base.TakeAPicture();
        }
    }
}
