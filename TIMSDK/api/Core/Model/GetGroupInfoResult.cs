using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 获取群组信息列表接口的返回
    /// </summary>
    public class GetGroupInfoResult
    {
        /// <summary>
        /// [错误码]
        /// </summary>
        [JsonProperty("get_groups_info_result_code")]
        public int kTIMGetGroupInfoResultCode { set; get; }
        /// <summary>
        /// 只读, 获取群组详细失败的描述信息
        /// </summary>
        [JsonProperty("get_groups_info_result_desc")]
        public string kTIMGetGroupInfoResultDesc { set; get; }
        /// <summary>
        /// 只读, 群组详细信息
        /// </summary>
        [JsonProperty("get_groups_info_result_info")]
        public GroupDetailInfo kTIMGetGroupInfoResultInfo { set; get; }
    }
}
