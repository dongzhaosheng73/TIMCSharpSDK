using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 未决请求类型
    /// </summary>
    public enum TIMGroupPendencyType
    {
        /// <summary>
        /// 请求加群
        /// </summary>
        kTIMGroupPendency_RequestJoin = 0,
        /// <summary>
        /// 邀请加群
        /// </summary>
        kTIMGroupPendency_InviteJoin = 1,
        /// <summary>
        /// 邀请和请求的
        /// </summary>
        kTIMGroupPendency_ReqAndInvite = 2
    }
}
