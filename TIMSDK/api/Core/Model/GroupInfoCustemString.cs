using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 群组成员信息自定义字段
    /// </summary>
    public class GroupInfoCustemString
    {
        /// <summary>
        /// 自定义数据Key
        /// </summary>
        [JsonProperty("group_info_custom_string_info_key")]
        public string kTIMGroupInfoCustemStringInfoKey { set; get; }
        /// <summary>
        /// 自定义数据value
        /// </summary>
        [JsonProperty("group_info_custom_string_info_value")]
        public string kTIMGroupInfoCustemStringInfoValue { set; get; }
    }
}
