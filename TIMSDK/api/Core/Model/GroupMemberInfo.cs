using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 群组成员信息
    /// </summary>
    public class GroupMemberInfo
    {
        /// <summary>
        /// 群组成员ID
        /// </summary>
        /// 
        [JsonProperty("group_member_info_identifier")]
        public string kTIMGroupMemberInfoIdentifier { set; get; }
        /// <summary>
        /// 群组成员加入时间
        /// </summary>
        /// 
        [JsonProperty("group_member_info_join_time")]
        public uint kTIMGroupMemberInfoJoinTime { set; get; }
        /// <summary>
        /// 群组成员角色
        /// </summary>
        /// 
        [JsonProperty("group_member_info_member_role")]
        public TIMGroupMemberRole kTIMGroupMemberInfoMemberRole { set; get; }
        /// <summary>
        /// 成员接收消息的选项
        /// </summary>
        /// 
        [JsonProperty("group_member_info_msg_flag")]
        public uint kTIMGroupMemberInfoMsgFlag { set; get; }
        [JsonProperty("group_member_info_msg_seq")]
        public uint kTIMGroupMemberInfoMsgSeq { set; get; }
        /// <summary>
        /// 成员禁言时间
        /// </summary>
        /// 
        [JsonProperty("group_member_info_shutup_time")]
        public uint kTIMGroupMemberInfoShutupTime { set; get; }
        /// <summary>
        /// 成员群名片
        /// </summary>
        /// 
        [JsonProperty("group_member_info_name_card")]
        public string kTIMGroupMemberInfoNameCard { set; get; }
        /// <summary>
        /// 自定义字段
        /// </summary>
        /// 
        [JsonProperty("group_member_info_custom_info")]
        public List<GroupMemberInfoCustemString> kTIMGroupMemberInfoCustomInfo { set; get; }
    }
}
