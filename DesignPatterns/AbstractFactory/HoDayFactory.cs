using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Ho 렌즈와 Ho 카메라 생성하는 클래스
    /// </summary>
    class HoDayFactory : IMakeCamera
    {
        /// <summary>
        /// 호환성 있는 HoLens를 생성하는 기능 구현
        /// </summary>
        /// <returns>HoLens</returns>
        public ITake MakeLens()
        {
            return new HoLens();
        }

        /// <summary>
        /// 호환성 있는 HoCamera를 생성하는 기능 구현
        /// </summary>
        /// <returns>HoCamera</returns>
        public Camera MakeCamera()
        {
            return new HoCamera();
        }
    }
}
