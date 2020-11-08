using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 邀请成员接口的返回
    /// </summary>
    public class GroupInviteMemberResult
    {
        /// <summary>
        /// 只读, 被邀请加入群组的用户ID
        /// </summary>
        [JsonProperty("group_invite_member_result_identifier")]
        public string kTIMGroupInviteMemberResultIdentifier { set; get; }
        /// <summary>
        /// 只读, 邀请结果
        /// </summary>
        [JsonProperty("group_invite_member_result_result")]
        public TIMHandleGroupMemberResult kTIMGroupInviteMemberResultResult { set; get; }
    }
}
