using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 删除成员接口的参数
    /// </summary>
    public class GroupDeleteMemberParam
    {
        /// <summary>
        /// 群组ID
        /// </summary>
        [JsonProperty("group_delete_member_param_group_id")]
        public string kTIMGroupDeleteMemberParamGroupId { set; get; }
        /// <summary>
        /// 被删除群组成员数组
        /// </summary>
        [JsonProperty("group_delete_member_param_identifier_array")]
        public List<string> kTIMGroupDeleteMemberParamIdentifierArray { set; get; }
        /// <summary>
        ///  用于自定义数据
        /// </summary>
        [JsonProperty("group_delete_member_param_user_data")]
        public string kTIMGroupDeleteMemberParamUserData { set; get; }
    }
}
