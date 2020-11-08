using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 消息删除接口的参数
    /// </summary>
    public class MsgDeleteParam
    {
        [JsonProperty("msg_delete_param_msg")]
        public TMessage kTIMMsgDeleteParamMsg { set; get; }
        [JsonProperty("msg_delete_param_is_remble")]
        public bool kTIMMsgDeleteParamIsRamble { set; get; }
    }
}
