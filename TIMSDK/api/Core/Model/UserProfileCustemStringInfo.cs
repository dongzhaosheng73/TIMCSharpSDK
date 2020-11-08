using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 用户自定义资料字段，字符串。
    /// </summary>
    public class GroupMemberInfoCustemString
    {
        /// <summary>
        /// 用户自定义资料字段的 key 值（包含前缀 Tag_Profile_Custom_）
        /// </summary>
        /// 
        [JsonProperty("user_profile_custom_string_info_key")]
        public string kTIMUserProfileCustemStringInfoKey { set; get; }
        /// <summary>
        /// 该字段对应的字符串值
        /// </summary>
        /// 
        [JsonProperty("user_profile_custom_string_info_value")]
        public string kTIMUserProfileCustemStringInfoValue { set; get; }
    }
}
