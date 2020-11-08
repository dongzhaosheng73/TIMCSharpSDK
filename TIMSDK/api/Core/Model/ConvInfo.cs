using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 会话信息
    /// </summary>
    public class ConvInfo
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        /// 
        [JsonProperty("conv_id")]
        public string kTIMConvId { set; get; }
        /// <summary>
        /// 会话类型
        /// </summary>
        /// 
        [JsonProperty("conv_type")]
        public TIMConvType kTIMConvType { set; get; }
        /// <summary>
        /// 会话所有者
        /// </summary>
        /// 
        [JsonProperty("conv_owner")]
        public string kTIMConvOwner { set; get; }
        /// <summary>
        /// 会话未读计数
        /// </summary>
        /// 
        [JsonProperty("conv_unread_num")]
        public ulong kTIMConvUnReadNum { set; get; }
        /// <summary>
        /// 会话激活时间
        /// </summary>
        /// 
        [JsonProperty("conv_active_time")]
        public ulong kTIMConvActiveTime { set; get; }
        /// <summary>
        /// 会话是否有最后一条消息
        /// </summary>
        /// 
        [JsonProperty("conv_is_has_lastmsg")]
        public bool kTIMConvIsHasLastMsg { set; get; }
        /// <summary>
        /// 会话是否有草稿
        /// </summary>
        /// 
        [JsonProperty("conv_is_has_draft")]
        public bool kTIMConvIsHasDraft { set; get; }
        /// <summary>
        /// 会话最后一条消息
        /// </summary>
        /// 
        [JsonProperty("conv_last_msg")]
        public TMessage kTIMConvLastMsg { set; get; }
        /// <summary>
        /// 会话草稿
        /// </summary>
        /// 
        [JsonProperty("conv_draft")]
        public Draft kTIMConvDraft { set; get; }
    }
}
