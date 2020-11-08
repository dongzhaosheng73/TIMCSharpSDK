using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 群组系统消息-群组成员禁言
    /// </summary>
    public class GroupTipMemberChangeInfo
    {
        /// <summary>
        /// 只读, 群组成员ID
        /// </summary>
        [JsonProperty("group_tips_member_change_info_identifier")]
        public string kTIMGroupTipMemberChangeInfoIdentifier { set; get; }
        /// <summary>
        /// 只读, 禁言时间
        /// </summary>
        [JsonProperty("kTIMGroupTipMemberChangeInfoShutupTime")]
        public uint kTIMGroupTipMemberChangeInfoShutupTime { set; get; }

    }
}
