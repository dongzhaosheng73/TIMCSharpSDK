using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class MsgBatchSendResult
    {
        /// <summary>
        /// 只读, 群发的单个ID
        /// </summary>
        [JsonProperty("msg_batch_send_result_identifier")]
        public string kTIMMsgBatchSendResultIdentifier { set; get; }
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("msg_batch_send_result_code")]
        public int kTIMMsgBatchSendResultCode { set; get; }
        /// <summary>
        /// 只读, 消息发送的描述
        /// </summary>
        [JsonProperty("msg_batch_send_result_desc")]
        public string kTIMMsgBatchSendResultDesc { set; get; }
        /// <summary>
        /// 只读, 发送的消息
        /// </summary>
        [JsonProperty("msg_batch_send_result_msg")]
        public TMessage kTIMMsgBatchSendResultMsg { set; get; }
    }
}
