using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    ///  设置群成员信息接口的参数
    /// </summary>
    public class GroupModifyMemberInfoParam
    {
        /// <summary>
        ///  只写(必填), 群组ID
        /// </summary>
        [JsonProperty("group_modify_member_info_group_id")]
        public string kTIMGroupModifyMemberInfoParamGroupId { set; get; }
        /// <summary>
        /// 只写(必填), 被设置信息的成员ID
        /// </summary>
        [JsonProperty("group_modify_member_info_identifier")]
        public string kTIMGroupModifyMemberInfoParamIdentifier { set; get; }
        /// <summary>
        ///  只写(必填), 修改类型,可设置多个值按位
        /// </summary>
        [JsonProperty("group_modify_member_info_modify_flag")]
        public TIMGroupMemberModifyInfoFlag kTIMGroupModifyMemberInfoParamModifyFlag { set; get; }
        /// <summary>
        ///  只写(选填), 修改消息接收选项,                  当 modify_flag 包含 kTIMGroupMemberModifyFlag_MsgFlag 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_member_info_msg_flag")]
        public uint kTIMGroupModifyMemberInfoParamMsgFlag { set; get; }
        /// <summary>
        /// 只写(选填), 修改成员角色, 当 modify_flag 包含 kTIMGroupMemberModifyFlag_MemberRole 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_member_info_member_role")]
        public TIMGroupMemberRole kTIMGroupModifyMemberInfoParamMemberRole { set; get; }
        /// <summary>
        /// 只写(选填), 修改禁言时间,                      当 modify_flag 包含 kTIMGroupMemberModifyFlag_ShutupTime 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_member_info_shutup_time")]
        public uint kTIMGroupModifyMemberInfoParamShutupTime { set; get; }
        /// <summary>
        /// 只写(选填), 修改群名片,                        当 modify_flag 包含 kTIMGroupMemberModifyFlag_NameCard 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_member_info_name_card")]
        public string kTIMGroupModifyMemberInfoParamNameCard { set; get;}
        /// <summary>
        /// 只写(选填), 请参考[自定义字段]
        /// </summary>
        [JsonProperty("group_modify_member_info_custom_info")]
        public List<GroupMemberInfoCustemString> kTIMGroupModifyMemberInfoParamCustomInfo { set; get; }

    }
}
