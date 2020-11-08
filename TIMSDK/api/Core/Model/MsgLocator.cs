using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 消息定位符。
    /// </summary>
    public class MsgLocator : IMessage
    {
        /// <summary>
        /// 要查找的消息所属的会话ID
        /// </summary>
        /// 
        [JsonProperty("message_locator_conv_id")]
        public bool kTIMMsgLocatorConvId { set; get; }
        /// <summary>
        ///   要查找的消息所属的会话类型
        /// </summary>
        /// 
        [JsonProperty("message_locator_conv_type")]
        public bool kTIMMsgLocatorConvType { set; get; }
        /// <summary>
        /// 读写(必填), 要查找的消息是否是被撤回。true被撤回的，false非撤回的。默认值为false
        /// </summary>
        [JsonProperty("message_locator_is_revoked")]
        public bool kTIMMsgLocatorIsRevoked { set; get; }
        /// <summary>
        /// 读写(必填), 要查找的消息的时间戳
        /// </summary>
        [JsonProperty("message_locator_time")]
        public ulong kTIMMsgLocatorTime { set; get; }
        /// <summary>
        /// 读写(必填), 要查找的消息的序列号
        /// </summary>
        [JsonProperty("message_locator_seq")]
        public ulong kTIMMsgLocatorSeq { set; get; }
        /// <summary>
        /// 读写(必填), 要查找的消息的发送者是否是自己。true发送者是自己，false发送者不是自己。默认值为false
        /// </summary>
        [JsonProperty("message_locator_is_self")]
        public bool kTIMMsgLocatorIsSelf { set; get; }
        /// <summary>
        /// 读写(必填), 要查找的消息随机码
        /// </summary>
        [JsonProperty("message_locator_rand")]
        public ulong kTIMMsgLocatorRand { set; get; }
        /// <summary>
        /// 读写(必填), 要查找的消息的唯一标识
        /// </summary>
        [JsonProperty("message_locator_unique_id")]
        public ulong kTIMMsgLocatorUniqueId { set; get; }
    }
}
