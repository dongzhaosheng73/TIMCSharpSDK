using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class OfflinePushConfig
    {
        /// <summary>
        /// 当前消息在对方收到离线推送时候展示内容
        /// </summary>
        /// 
        [JsonProperty("offline_push_config_desc")]
        public string kTIMOfflinePushConfigDesc { set; get; }
        /// <summary>
        /// 当前消息离线推送时的扩展字段
        /// </summary>
        /// 
        [JsonProperty("offline_push_config_ext")]
        public string kTIMOfflinePushConfigExt { set; get; }
        /// <summary>
        /// 当前消息是否允许推送，默认允许推送 kTIMOfflinePushFlag_Default
        /// </summary>
        /// 
        [JsonProperty("offline_push_config_flag")]
        public TIMOfflinePushFlag kTIMOfflinePushConfigFlag { set; get; }
        /// <summary>
        /// Android 离线推送配置
        /// </summary>
        /// 
        [JsonProperty("offline_push_config_ios_config")]
        public AndroidOfflinePushConfig kTIMOfflinePushConfigAndroidConfig { set; get; }
        /// <summary>
        /// iOS 离线推送配置
        /// </summary>
        /// 
        [JsonProperty("offline_push_config_android_config")]
        public IOSOfflinePushConfig kTIMOfflinePushConfigIOSConfig { set; get; }
    }
}
