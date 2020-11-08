using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// Android 离线推送模式
    /// </summary>
    public enum TIMAndroidOfflinePushNotifyMode
    {
        /// <summary>
        /// 普通通知栏消息模式，离线消息下发后，点击通知栏消息直接启动应用，不会给应用进行回调
        /// </summary>
        kTIMAndroidOfflinePushNotifyMode_Normal = 0,
        /// <summary>
        /// 自定义消息模式，离线消息下发后，点击通知栏消息会给应用进行回调
        /// </summary>
        kTIMAndroidOfflinePushNotifyMode_Custom = 1
    }
}
