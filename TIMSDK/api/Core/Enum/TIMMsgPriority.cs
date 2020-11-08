using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 标识消息的优先级，数字越大优先级越低。
    /// </summary>
    public enum TIMMsgPriority
    {
        /// <summary>
        /// 优先级最高，一般为红包或者礼物消息
        /// </summary>
        kTIMMsgPriority_High = 0,
        /// <summary>
        /// 表示优先级次之，建议为普通消息
        /// </summary>
        kTIMMsgPriority_Normal = 1,
        /// <summary>
        /// 建议为点赞消息等
        /// </summary>
        kTIMMsgPriority_Low = 2,
        /// <summary>
        /// 优先级最低，一般为成员进退群通知（后台下发）
        /// </summary>
        kTIMMsgPriority_Lowest = 3
    }
}
