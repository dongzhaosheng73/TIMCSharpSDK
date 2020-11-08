using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 消息获取接口的参数
    /// </summary>
    public class MsgGetMsgListParam
    {
        [JsonProperty("msg_getmsglist_param_last_msg")]
        public TMessage kTIMMsgGetMsgListParamLastMsg { set; get; }
        [JsonProperty("msg_getmsglist_param_is_remble")]
        public bool kTIMMsgGetMsgListParamIsRamble { set; get; }
        [JsonProperty("msg_getmsglist_param_is_forward")]
        public bool kTIMMsgGetMsgListParamIsForward { set; get; }
        [JsonProperty("msg_getmsglist_param_count")]
        public int kTIMMsgGetMsgListParamCount { set; get; }
    }
}
