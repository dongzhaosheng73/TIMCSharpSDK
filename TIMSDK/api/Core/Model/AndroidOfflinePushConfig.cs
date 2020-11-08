using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 消息在 Android 系统上的离线推送配置。
    /// </summary>
    public class AndroidOfflinePushConfig
    {
        /// <summary>
        /// 通知标题
        /// </summary>
        /// 
        [JsonProperty("android_offline_push_config_title")]
        public string kTIMAndroidOfflinePushConfigTitle { set; get; }
        /// <summary>
        /// 当前消息在 Android 设备上的离线推送提示声音 URL
        /// </summary>
        /// 
        [JsonProperty("android_offline_push_config_sound")]
        public string kTIMAndroidOfflinePushConfigSound { set; get; }
        /// <summary>
        /// 当前消息的通知模式
        /// </summary>
        /// 
        [JsonProperty("android_offline_push_config_notify_mode")]
        public TIMAndroidOfflinePushNotifyMode kTIMAndroidOfflinePushConfigNotifyMode { set; get; }
        /// <summary>
        /// OPPO 的 ChannelID
        /// </summary>
        /// 
        [JsonProperty("android_offline_push_config_oppo_channel_id")]
        public string kTIMAndroidOfflinePushConfigOPPOChannelID { set; get; }
    }
}
