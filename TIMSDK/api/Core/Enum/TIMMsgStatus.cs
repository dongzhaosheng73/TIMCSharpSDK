using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 消息当前状态定义
    /// </summary>
    public enum TIMMsgStatus
    {
        /// <summary>
        /// 消息正在发送
        /// </summary>
        kTIMMsg_Sending = 0,
        /// <summary>
        /// 消息发送成功
        /// </summary>
        kTIMMsg_SendSucc = 2,
        /// <summary>
        /// 消息发送失败
        /// </summary>
        kTIMMsg_SendFail = 3,
        /// <summary>
        /// 消息已删除
        /// </summary>
        kTIMMsg_Deleted = 4,
        /// <summary>
        /// 消息导入状态
        /// </summary>
        kTIMMsg_LocalImported = 5,
        /// <summary>
        /// 消息撤回状态
        /// </summary>
        kTIMMsg_Revoked = 6
    }
}
