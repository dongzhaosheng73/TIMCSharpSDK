using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 群组类型。
    /// </summary>
    public enum TIMGroupType
    {
        /// <summary>
        /// 公开群
        /// </summary>
        kTIMGroup_Public = 0,
        /// <summary>
        /// 私有群
        /// </summary>
        kTIMGroup_Private = 1,
        /// <summary>
        /// 	聊天室
        /// </summary>
        kTIMGroup_ChatRoom = 2,
        /// <summary>
        /// 在线成员广播大群
        /// </summary>
        kTIMGroup_BChatRoom = 3,
        /// <summary>
        /// 互动直播聊天室
        /// </summary>
        kTIMGroup_AVChatRoom = 4
    }
}
