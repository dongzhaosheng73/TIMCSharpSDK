using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 群组信息修改的类型。
    /// </summary>
    public enum TIMGroupTipGroupChangeFlag
    {
        /// <summary>
        /// 修改群组名称
        /// </summary>
        kTIMGroupTipChangeFlag_Name = 0xa,
        /// <summary>
        /// 修改群简介
        /// </summary>
        kTIMGroupTipChangeFlag_Introduction = 11,
        /// <summary>
        /// 修改群公告
        /// </summary>
        kTIMGroupTipChangeFlag_Notification = 12,
        /// <summary>
        /// 修改群头像 URL
        /// </summary>
        kTIMGroupTipChangeFlag_FaceUrl = 13,
        /// <summary>
        /// 修改群所有者
        /// </summary>
        kTIMGroupTipChangeFlag_Owner = 14
    }
}
