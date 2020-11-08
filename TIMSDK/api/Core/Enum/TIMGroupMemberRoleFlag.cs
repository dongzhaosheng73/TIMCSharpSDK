using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.API.Core.Enum
{
    /// <summary>
    /// 群组成员角色标识。
    /// </summary>
    public enum TIMGroupMemberRoleFlag
    {
        /// <summary>
        /// 获取全部角色类型
        /// </summary>
        kTIMGroupMemberRoleFlag_All = 0x00,
        /// <summary>
        /// 获取所有者（群主）
        /// </summary>
        kTIMGroupMemberRoleFlag_Owner = 0x01,
        /// <summary>
        /// 获取管理员，不包括群主
        /// </summary>
        kTIMGroupMemberRoleFlag_Admin = 0x01 << 1,
        /// <summary>
        /// 获取普通群成员，不包括群主和管理员
        /// </summary>
        kTIMGroupMemberRoleFlag_Member = 0x01 << 2
    }
}
