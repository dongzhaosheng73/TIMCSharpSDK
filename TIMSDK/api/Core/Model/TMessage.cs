using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TIMSDK.Model
{

    /// <summary>
    /// 消息
    /// </summary>
    public class TMessage: IMessage
    {
        /// <summary>
        /// 消息内元素列表
        /// </summary>
        /// 
        [JsonProperty("message_elem_array")]
        public List<Elem> kTIMMsgElemArray { set; get; }
        /// <summary>
        /// 消息所属会话 ID
        /// </summary>
        /// 
        [JsonProperty("message_conv_id")]
        public string kTIMMsgConvId { set; get; }
        /// <summary>
        /// 消息所属会话类型
        /// </summary>
        /// 
        [JsonProperty("message_conv_type")]
        public TIMConvType kTIMMsgConvType { set; get; }
        /// <summary>
        /// 消息的发送者
        /// </summary>
        /// 
        [JsonProperty("message_sender")]
        public string kTIMMsgSender { set; get; }
        /// <summary>
        /// 消息优先级
        /// </summary>
        /// 
        [JsonProperty("message_priority")]
        public TIMMsgPriority kTIMMsgPriority { set; get; }
        /// <summary>
        /// 客户端时间
        /// </summary>
        /// 
        [JsonProperty("message_client_time")]
        public ulong kTIMMsgClientTime { set; get; }
        /// <summary>
        /// 服务端时间
        /// </summary>
        /// 
        [JsonProperty("message_server_time")]
        public ulong kTIMMsgServerTime { set; get; }
        /// <summary>
        /// 消息是否来自自己
        /// </summary>
        /// 
        [JsonProperty("message_is_from_self")]
        public bool kTIMMsgIsFormSelf { set; get; }
        /// <summary>
        /// 消息是否已读
        /// </summary>
        /// 
        [JsonProperty("message_is_read")]
        public bool kTIMMsgIsRead { set; get; }
        /// <summary>
        /// 消息是否是在线消息，false 表示普通消息，true 表示阅后即焚消息，默认为 false
        /// </summary>
        /// 
        [JsonProperty("message_is_online_msg")]
        public bool kTIMMsgIsOnlineMsg { set; get; }
        /// <summary>
        /// 消息是否被会话对方已读
        /// </summary>
        /// 
        [JsonProperty("message_is_peer_read")]
        public bool kTIMMsgIsPeerRead { set; get; }
        /// <summary>
        /// 消息当前状态
        /// </summary>
        /// 
        [JsonProperty("message_status")]
        public TIMMsgStatus kTIMMsgStatus { set; get; }
        /// <summary>
        /// 消息的唯一标识
        /// </summary>
        /// 
        [JsonProperty("message_unique_id")]
        public ulong kTIMMsgUniqueId { set; get; }
        /// <summary>
        /// 消息的随机码
        /// </summary>
        /// 
        [JsonProperty("message_rand")]
        public ulong kTIMMsgRand { set; get; }
        /// <summary>
        /// 消息序列
        /// </summary>
        /// 
        [JsonProperty("message_seq")]
        public ulong kTIMMsgSeq { set; get; }
        /// <summary>
        /// 自定义整数值字段
        /// </summary>
        /// 
        [JsonProperty("message_custom_int")]
        public int kTIMMsgCustomInt { set; get; }
        /// <summary>
        /// 自定义数据字段
        /// </summary>
        /// 
        [JsonProperty("message_custom_str")]
        public string kTIMMsgCustomStr { set; get; }
        /// <summary>
        /// 消息的发送者的用户资料
        /// </summary>
        /// 
        [JsonProperty("message_sender_profile")]
        public UserProfile kTIMMsgSenderProfile { set; get; }
        /// <summary>
        /// 消息发送者在群里面的信息，只有在群会话有效。目前仅能获取字段kTIMGroupMemberInfoIdentifier、kTIMGroupMemberInfoNameCard
        /// 其他的字段建议通过TIMGroupGetMemberInfoList接口获取
        /// </summary>
        /// 
        [JsonProperty("message_sender_group_member_info")]
        public GroupMemberInfo kTIMMsgSenderGroupMemberInfo { set; get; }
        /// <summary>
        /// 消息的离线推送设置
        /// </summary>
        /// 
        [JsonProperty("message_offlie_push_config")]
        public OfflinePushConfig kTIMMsgOfflinePushConfig { set; get; }


    }
}
