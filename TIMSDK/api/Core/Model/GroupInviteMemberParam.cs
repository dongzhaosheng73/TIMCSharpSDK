using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 邀请成员接口的参数。
    /// </summary>
    public class GroupInviteMemberParam
    {
        [JsonProperty("group_invite_member_param_group_id")]
        public string kTIMGroupInviteMemberParamGroupId { set; get; }
        [JsonProperty("group_invite_member_param_identifier_array")]
        public List<string> kTIMGroupInviteMemberParamIdentifierArray { set; get; }
        [JsonProperty("group_invite_member_param_user_data")]
        public string kTIMGroupInviteMemberParamUserData { set; get; }
    }
}
