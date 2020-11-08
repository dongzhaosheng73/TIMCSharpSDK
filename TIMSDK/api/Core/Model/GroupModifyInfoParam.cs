using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 设置群信息接口的参数
    /// </summary>
    public class GroupModifyInfoParam
    {
        /// <summary>
        /// 只写(必填), 群组ID
        /// </summary>
        [JsonProperty("group_modify_info_param_group_id")]
        public string kTIMGroupModifyInfoParamGroupId { set; get; }
        /// <summary>
        ///  只写(必填), 修改标识,可设置多个值按位或
        /// </summary>
        [JsonProperty("group_modify_info_param_modify_flag")]
        public TIMGroupModifyInfoFlag kTIMGroupModifyInfoParamModifyFlag { set; get; }
        /// <summary>
        /// 只写(选填), 修改群组名称, 当 modify_flag 包含 kTIMGroupModifyInfoFlag_Name 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_group_name")]
        public string  kTIMGroupModifyInfoParamGroupName { set; get; }
        /// <summary>
        /// 只写(选填), 修改群公告,        当 modify_flag 包含 kTIMGroupModifyInfoFlag_Notification 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_notification")]
        public string kTIMGroupModifyInfoParamNotification { set; get; }
        /// <summary>
        /// string, 只写(选填), 修改群简介,        当 modify_flag 包含 kTIMGroupModifyInfoFlag_Introduction 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_introduction")]
        public string kTIMGroupModifyInfoParamIntroduction { set; get; }
        /// <summary>
        ///  只写(选填), 修改群头像URL,     当 modify_flag 包含 kTIMGroupModifyInfoFlag_FaceUrl 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_face_url")]
        public string kTIMGroupModifyInfoParamFaceUrl { set; get; }
        /// <summary>
        /// 只写(选填), 修改群组添加选项,    当 modify_flag 包含 kTIMGroupModifyInfoFlag_AddOption 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_add_option")]
        public uint kTIMGroupModifyInfoParamAddOption { set; get; }
        /// <summary>
        /// 只写(选填), 修改群最大成员数,    当 modify_flag 包含 kTIMGroupModifyInfoFlag_MaxMmeberNum 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_max_member_num")]
        public uint kTIMGroupModifyInfoParamMaxMemberNum { set; get; }
        /// <summary>
        /// 只写(选填), 修改群是否可见,      当 modify_flag 包含 kTIMGroupModifyInfoFlag_Visible 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_visible")]
        public uint kTIMGroupModifyInfoParamVisible { set; get; }
        /// <summary>
        /// 只写(选填), 修改群是否被搜索,    当 modify_flag 包含 kTIMGroupModifyInfoFlag_Searchable 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_searchable")]
        public uint kTIMGroupModifyInfoParamSearchAble { set; get; }
        /// <summary>
        /// 只写(选填), 修改群是否全体禁言,  当 modify_flag 包含 kTIMGroupModifyInfoFlag_ShutupAll 时必填,其他情况不用填
        /// </summary>
        [JsonProperty("group_modify_info_param_is_shutup_all")]
        public bool kTIMGroupModifyInfoParamIsShutupAll { set; get; }
        /// <summary>
        /// 只写(选填), 修改群主所有者,     当 modify_flag 包含 kTIMGroupModifyInfoFlag_Owner 时必填,其他情况不用填。此时 modify_flag 不能包含其他值，当修改群主时，同时修改其他信息已无意义
        /// </summary>
        [JsonProperty("group_modify_info_param_owner")]
        public string kTIMGroupModifyInfoParamOwner { set; get; }
        /// <summary>
        /// 只写(选填), 请参考[自定义字段]
        /// </summary>
        [JsonProperty("group_modify_info_param_custom_info")]
        public List<GroupInfoCustemString> kTIMGroupModifyInfoParamCustomInfo { set; get; }
    }
}
