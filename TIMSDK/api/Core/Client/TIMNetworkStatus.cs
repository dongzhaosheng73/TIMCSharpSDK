using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    public enum TIMNetworkStatus
    {
        /// <summary>
        /// 已连接
        /// </summary>
        kTIMConnected = 0,
        /// <summary>
        /// 失去连接
        /// </summary>
        kTIMDisconnected = 1,
        /// <summary>
        /// 正在连接
        /// </summary>
        kTIMConnecting = 2,
        /// <summary>
        /// 连接失败
        /// </summary>
        kTIMConnectFailed = 3
    }
}
