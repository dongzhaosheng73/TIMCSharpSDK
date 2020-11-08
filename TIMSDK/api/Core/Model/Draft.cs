using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 草稿信息
    /// </summary>
    public class Draft
    {
        /// <summary>
        /// 草稿内的消息
        /// </summary>
        /// 
        [JsonProperty("draft_msg")]
        public TMessage kTIMDraftMsg { set; get; }
        /// <summary>
        /// 用户自定义数据
        /// </summary>
        /// 
        [JsonProperty("draft_user_define")]
        public string kTIMDraftUserDefine { set; get; }
        /// <summary>
        /// 草稿最新编辑时间
        /// </summary>
        /// 
        [JsonProperty("draft_edit_time")]
        public uint kTIMDraftEditTime { set; get; }
    }
}
