using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Ev 렌즈와 Ev 카메라 생성하는 클래스
    /// </summary>
    class EvDayFactory :IMakeCamera
    {
        /// <summary>
        /// 호환성 있는 EvLens를 생성하는 기능 구현
        /// </summary>
        /// <returns>EvLens</returns>
        public ITake MakeLens()
        {
            return new EvLens();
        }

        /// <summary>
        /// 호환성 있는 EvCamera를 생성하는 기능 구현
        /// </summary>
        /// <returns>EvCamera</returns>
        public Camera MakeCamera()
        {
            return new EvCamera();
        }
    }
}
