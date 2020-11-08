using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 群组消息接收选项
    /// </summary>
    public enum TIMGroupReceiveMessageOpt
    {
        /// <summary>
        /// 接收群消息并提示
        /// </summary>
        kTIMRecvGroupMsgOpt_ReceiveAndNotify = 0,
        /// <summary>
        /// 不接收群消息，服务器不会进行转发
        /// </summary>
        kTIMRecvGroupMsgOpt_NotReceive = 1,
        /// <summary>
        /// 接收群消息，不提示
        /// </summary>
        kTIMRecvGroupMsgOpt_ReceiveNotNotify = 2
    }
}
