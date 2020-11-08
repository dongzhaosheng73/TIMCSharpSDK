using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 消息已读回执
    /// </summary>
    public class MessageReceipt
    {
        /// <summary>
        /// 只读, 会话ID
        /// </summary>
        [JsonProperty("msg_receipt_conv_id")]
        public string kTIMMsgReceiptConvId { set; get; }
        /// <summary>
        /// 只读, 会话类型
        /// </summary>
        [JsonProperty("msg_receipt_conv_type")]
        public TIMConvType kTIMMsgReceiptConvType { set; get; }
        /// <summary>
        /// 只读, 时间戳
        /// </summary>
        [JsonProperty("msg_receipt_time_stamp")]
        public ulong kTIMMsgReceiptTimeStamp { set; get; }
    }
}
