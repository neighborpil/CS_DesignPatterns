using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 렌즈의 기능에 대한 추상적인 약속
    /// </summary>
    interface ITake
    {
        /// <summary>
        /// 상을 맺히는 기능에 대한 약속
        /// </summary>
        void Take();
    }
}
