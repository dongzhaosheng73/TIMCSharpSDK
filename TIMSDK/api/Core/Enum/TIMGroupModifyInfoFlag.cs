using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 设置（修改）群组信息的类型
    /// </summary>
    public enum TIMGroupModifyInfoFlag
    {
        kTIMGroupModifyInfoFlag_None = 0x00,
        /// <summary>
        /// 修改群组名称
        /// </summary>
        kTIMGroupModifyInfoFlag_Name = 0x01,
        /// <summary>
        /// 修改群公告
        /// </summary>
        kTIMGroupModifyInfoFlag_Notification = 0x01 << 1,
        /// <summary>
        /// 修改群简介
        /// </summary>
        kTIMGroupModifyInfoFlag_Introduction = 0x01 << 2,
        /// <summary>
        /// 修改群头像 URL
        /// </summary>
        kTIMGroupModifyInfoFlag_FaceUrl = 0x01 << 3,
        /// <summary>
        /// 修改群组添加选项
        /// </summary>
        kTIMGroupModifyInfoFlag_AddOption = 0x01 << 4,
        /// <summary>
        /// 修改群最大成员数
        /// </summary>
        kTIMGroupModifyInfoFlag_MaxMmeberNum = 0x01 << 5,
        /// <summary>
        /// 修改群是否可见
        /// </summary>
        kTIMGroupModifyInfoFlag_Visible = 0x01 << 6,
        /// <summary>
        /// 修改群是否被搜索
        /// </summary>
        kTIMGroupModifyInfoFlag_Searchable = 0x01 << 7,
        /// <summary>
        /// 修改群是否全体禁言
        /// </summary>
        kTIMGroupModifyInfoFlag_ShutupAll = 0x01 << 8,
        /// <summary>
        /// 修改群自定义信息
        /// </summary>
        kTIMGroupModifyInfoFlag_Custom = 0x01 << 9,
        /// <summary>
        /// 修改群主
        /// </summary>
        kTIMGroupModifyInfoFlag_Owner = 0x01 << 31,
    }
}
