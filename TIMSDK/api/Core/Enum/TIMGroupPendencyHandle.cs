using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 群未决处理状态
    /// </summary>
    public enum TIMGroupPendencyHandle
    {
        /// <summary>
        /// 未处理
        /// </summary>
        kTIMGroupPendency_NotHandle = 0,
        /// <summary>
        /// 他人处理
        /// </summary>
        kTIMGroupPendency_OtherHandle = 1,
        /// <summary>
        /// 操作方处理
        /// </summary>
        kTIMGroupPendency_OperatorHandle = 2
    }
}
