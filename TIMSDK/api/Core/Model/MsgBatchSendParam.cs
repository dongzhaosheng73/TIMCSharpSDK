using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 消息群发接口的参数。
    /// </summary>
    public class MsgBatchSendParam
    {
        /// <summary>
        ///  只写(必填), 群发的ID列表
        /// </summary>
        [JsonProperty("msg_batch_send_param_identifier_array")]
        public List<string> kTIMMsgBatchSendParamIdentifierArray { set; get; }
        /// <summary>
        /// 只写(必填), 群发的消息
        /// </summary>
        [JsonProperty("msg_batch_send_param_msg")]
        public TMessage kTIMMsgBatchSendParamMsg { set; get; }
    }
}
