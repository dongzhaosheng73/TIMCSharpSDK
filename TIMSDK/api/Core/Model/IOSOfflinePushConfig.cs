using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class IOSOfflinePushConfig
    {
        /// <summary>
        ///  通知标题
        /// </summary>
        /// 
        [JsonProperty("ios_offline_push_config_title")]
        public string kTIMIOSOfflinePushConfigTitle { set; get; }
        /// <summary>
        /// 当前消息在 iOS 设备上的离线推送提示声音 URL。当设置为 push。no_sound 时表示无提示音无振动
        /// </summary>
        /// 
        [JsonProperty("ios_offline_push_config_sound")]
        public string kTIMIOSOfflinePushConfigSound { set; get; }
        /// <summary>
        /// 是否忽略 badge 计数。若为 true，在 iOS 接收端，这条消息不会使 App 的应用图标未读计数增加
        /// </summary>
        /// 
        [JsonProperty("kTIMIOSOfflinePushConfigIgnoreBadge")]
        public bool kTIMIOSOfflinePushConfigIgnoreBadge { set; get; }
    }
}
