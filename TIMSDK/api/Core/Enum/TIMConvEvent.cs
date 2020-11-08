using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    public enum TIMConvEvent
    {
        /// <summary>
        /// 会话新增，例如收到一条新消息，产生一个新的会话是事件触发
        /// </summary>
        kTIMConvEvent_Add = 0,
        /// <summary>
        /// 会话删除，例如自己删除某会话时会触发
        /// </summary>
        kTIMConvEvent_Del = 1,
        /// <summary>
        /// 会话更新，会话内消息的未读计数变化和收到新消息时触发
        /// </summary>
        kTIMConvEvent_Update = 2
    }
}
