using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    public enum TIMGroupTipType
    {
        /// <summary>
        /// 无效的群提示
        /// </summary>
        [Description("无效的群提示")]
        kTIMGroupTip_None = 0,
        /// <summary>
        /// 邀请加入提示
        /// </summary>
        [Description("加入")]
        kTIMGroupTip_Invite = 1,
        /// <summary>
        /// 退群提示
        /// </summary>
        [Description("退群")]
        kTIMGroupTip_Quit = 2,
        /// <summary>
        /// 踢人提示
        /// </summary>
        [Description("被踢出该群")]
        kTIMGroupTip_Kick = 3,
        /// <summary>
        /// 设置管理员提示
        /// </summary>
        [Description("被设置为管理员")]
        kTIMGroupTip_SetAdmin = 4,
        /// <summary>
        /// 取消管理员提示
        /// </summary>
        [Description("被取消管理员资格")]
        kTIMGroupTip_CancelAdmin = 5,
        /// <summary>
        /// 群信息修改提示
        /// </summary>
        [Description("修改群信息")]
        kTIMGroupTip_GroupInfoChange = 6,
        /// <summary>
        /// 群成员信息修改提示
        /// </summary>
        [Description("信息已修改")]
        kTIMGroupTip_MemberInfoChange = 7
    }
}
