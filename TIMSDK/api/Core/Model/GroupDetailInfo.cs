using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 群组详细信息。
    /// </summary>
    public class GroupDetailInfo
    {
        /// <summary>
        /// 只读, 群组ID
        /// </summary>
        [JsonProperty("group_detial_info_group_id")]
        public string kTIMGroupDetialInfoGroupId { set; get; }
        /// <summary>
        /// 只读, 群组类型
        /// </summary>
        [JsonProperty("group_detial_info_group_type")]
        public TIMGroupType kTIMGroupDetialInfoGroupType { set; get; }
        /// <summary>
        /// 只读, 群组名称
        /// </summary>
        [JsonProperty("group_detial_info_group_name")]
        public string kTIMGroupDetialInfoGroupName { set; get; }
        /// <summary>
        /// 只读, 群组公告
        /// </summary>
        [JsonProperty("group_detial_info_notification")]
        public string kTIMGroupDetialInfoNotification { set; get; }
        /// <summary>
        /// 只读, 群组简介
        /// </summary>
        [JsonProperty("group_detial_info_introduction")]
        public string kTIMGroupDetialInfoIntroduction { set; get; }
        /// <summary>
        /// 只读, 群组头像URL
        /// </summary>
        [JsonProperty("group_detial_info_face_url")]
        public string kTIMGroupDetialInfoFaceUrl { set; get; }
        /// <summary>
        ///  只读, 群组创建时间
        /// </summary>
        [JsonProperty("group_detial_info_create_time")]
        public uint kTIMGroupDetialInfoCreateTime { set; get; }
        /// <summary>
        /// 只读, 群资料的Seq，群资料的每次变更都会增加这个字段的值
        /// </summary>
        [JsonProperty("group_detial_info_info_seq")]
        public uint kTIMGroupDetialInfoInfoSeq { set; get; }
        /// <summary>
        /// 只读, 群组信息最后修改时间
        /// </summary>
        [JsonProperty("group_detial_info_last_info_time")]
        public uint kTIMGroupDetialInfoLastInfoTime { set; get; }
        /// <summary>
        /// 只读, 群最新消息的Seq
        /// </summary>
        [JsonProperty("group_detial_info_next_msg_seq")]
        public uint kTIMGroupDetialInfoNextMsgSeq { set; get;}
        /// <summary>
        /// 只读, 最新群组消息时间
        /// </summary>
        [JsonProperty("group_detial_info_last_msg_time")]
        public uint kTIMGroupDetialInfoLastMsgTime { set; get; }
        /// <summary>
        /// 只读, 群组当前成员数量
        /// </summary>
        [JsonProperty("group_detial_info_member_num")]
        public uint kTIMGroupDetialInfoMemberNum { set; get; }
        /// <summary>
        /// 只读, 群组最大成员数量
        /// </summary>
        [JsonProperty("group_detial_info_max_member_num")]
        public uint kTIMGroupDetialInfoMaxMemberNum { set; get; }
        /// <summary>
        ///  只读, 群组加群选项
        /// </summary>
        [JsonProperty("group_detial_info_add_option")]
        public TIMGroupAddOption kTIMGroupDetialInfoAddOption { set; get; }
        /// <summary>
        ///  群组在线成员数量
        /// </summary>
        [JsonProperty("group_detial_info_online_member_num")]
        public uint kTIMGroupDetialInfoOnlineMemberNum { set; get; }
        /// <summary>
        /// 群组成员是否对外可见
        /// </summary>
        [JsonProperty("group_detial_info_visible")]
        public uint kTIMGroupDetialInfoVisible { set; get; }
        /// <summary>
        /// 只读, 群组是否能被搜索
        /// </summary>
        [JsonProperty("group_detial_info_searchable")]
        public uint kTIMGroupDetialInfoSearchable { set; get; }
        /// <summary>
        /// 只读, 群组是否被设置了全员禁言
        /// </summary>
        [JsonProperty("group_detial_info_is_shutup_all")]
        public bool kTIMGroupDetialInfoIsShutupAll { set; get; }
        /// <summary>
        /// 只读, 群组所有者ID
        /// </summary>
        [JsonProperty("group_detial_info_owener_identifier")]
        public string kTIMGroupDetialInfoOwnerIdentifier { set; get; }
        /// <summary>
        /// 只读, 请参考[自定义字段]
        /// </summary>
        [JsonProperty("group_detial_info_custom_info")]
        public List<GroupInfoCustemString> kTIMGroupDetialInfoCustomInfo { set; get; }
    }
}
