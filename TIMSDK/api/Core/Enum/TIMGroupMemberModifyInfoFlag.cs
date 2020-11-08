using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 设置（修改）群成员信息的类型。
    /// </summary>
    public enum TIMGroupMemberModifyInfoFlag
    {
        kTIMGroupMemberModifyFlag_None = 0x00,
        /// <summary>
        /// 修改消息接收选项
        /// </summary>
        kTIMGroupMemberModifyFlag_MsgFlag = 0x01,
        /// <summary>
        /// 修改成员角色
        /// </summary>
        kTIMGroupMemberModifyFlag_MemberRole = 0x01 << 1,
        /// <summary>
        /// 修改禁言时间
        /// </summary>
        kTIMGroupMemberModifyFlag_ShutupTime = 0x01 << 2,
        /// <summary>
        /// 修改群名片
        /// </summary>
        kTIMGroupMemberModifyFlag_NameCard = 0x01 << 3,
        /// <summary>
        /// 修改群成员自定义信息
        /// </summary>
        kTIMGroupMemberModifyFlag_Custom = 0x01 << 4
    }
}
