using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 推送规则
    /// </summary>
    public enum TIMOfflinePushFlag
    {
        /// <summary>
        /// 按照默认规则进行推送
        /// </summary>
        kTIMOfflinePushFlag_Default = 0,
        /// <summary>
        /// 不进行推送
        /// </summary>
        kTIMOfflinePushFlag_NoPush = 1
    }
}
