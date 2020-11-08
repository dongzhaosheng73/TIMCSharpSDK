using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 群组基础信息
    /// </summary>
    public enum TIMHandleGroupMemberResult
    {
        /// <summary>
        /// 失败
        /// </summary>
        kTIMGroupMember_HandledErr = 0,
        /// <summary>
        /// 成功
        /// </summary>
        kTIMGroupMember_HandledSuc = 1,
        /// <summary>
        /// 已是群成员
        /// </summary>
        kTIMGroupMember_Included = 2,
        /// <summary>
        /// 已发送邀请
        /// </summary>
        kTIMGroupMember_Invited = 3
    }
}
