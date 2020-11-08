using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.API.Core.Enum
{
    /// <summary>
    /// 群组成员信息标识。
    /// </summary>
    public enum TIMGroupMemberInfoFlag
    {
        kTIMGroupMemberInfoFlag_None = 0x00,
        /// <summary>
        /// 加入时间
        /// </summary>
        kTIMGroupMemberInfoFlag_JoinTime = 0x01,
        /// <summary>
        /// 群消息接收选项
        /// </summary>
        kTIMGroupMemberInfoFlag_MsgFlag = 0x01 << 1,
        /// <summary>
        /// 成员已读消息 seq
        /// </summary>
        kTIMGroupMemberInfoFlag_MsgSeq = 0x01 << 2,
        /// <summary>
        /// 成员角色
        /// </summary>
        kTIMGroupMemberInfoFlag_MemberRole = 0x01 << 3,
        /// <summary>
        /// 禁言时间。当该值为0时表示没有被禁言
        /// </summary>
        kTIMGroupMemberInfoFlag_ShutupUntill = 0x01 << 4,
        /// <summary>
        /// 群名片
        /// </summary>
        kTIMGroupMemberInfoFlag_NameCard = 0x01 << 5
    }
}
