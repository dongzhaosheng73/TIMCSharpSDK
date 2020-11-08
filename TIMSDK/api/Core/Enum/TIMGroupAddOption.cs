using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 群组加群选项。
    /// </summary>
    public enum TIMGroupAddOption
    {
        /// <summary>
        /// 禁止加群
        /// </summary>
        kTIMGroupAddOpt_Forbid = 0,
        /// <summary>
        /// 需要管理员审批
        /// </summary>
        kTIMGroupAddOpt_Auth = 1,
        /// <summary>
        /// 任何人都可以加群
        /// </summary>
        kTIMGroupAddOpt_Any = 2
    }
}
