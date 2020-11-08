using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 创建群组接口的参数
    /// </summary>
    public class CreateGroupParam
    {
        /// <summary>
        /// 只写(必填), 群组名称
        /// </summary>
        [JsonProperty("create_group_param_group_name")]
        public string kTIMCreateGroupParamGroupName { set; get; }
        /// <summary>
        /// 只写(选填), 群组ID,不填时创建成功回调会返回一个后台分配的群ID
        /// </summary>
        [JsonProperty("create_group_param_group_id")]
        public string kTIMCreateGroupParamGroupId { set; get; }
        /// <summary>
        /// 只写(选填), 群组类型,默认为Public
        /// </summary>
        [JsonProperty("create_group_param_group_type")]
        public TIMGroupType kTIMCreateGroupParamGroupType { set; get; }
        /// <summary>
        /// 只写(选填), 群组初始成员数组
        /// </summary>
        [JsonProperty("create_group_param_group_member_array")]
        public List<GroupMemberInfo> kTIMCreateGroupParamGroupMemberArray { set; get; }
        /// <summary>
        /// 只写(选填), 群组公告,
        /// </summary>
        [JsonProperty("create_group_param_notification")]
        public string kTIMCreateGroupParamNotification { set; get; }
        /// <summary>
        /// 只写(选填), 群组简介,
        /// </summary>
        [JsonProperty("create_group_param_introduction")]
        public string kTIMCreateGroupParamIntroduction { set; get; }
        /// <summary>
        /// 只写(选填), 群组头像URL
        /// </summary>
        [JsonProperty("create_group_param_face_url")]
        public string kTIMCreateGroupParamFaceUrl { set; get; }
        /// <summary>
        /// 只写(选填), 加群选项，默认为Any
        /// </summary>
        [JsonProperty("create_group_param_add_option")]
        public TIMGroupAddOption kTIMCreateGroupParamAddOption { set; get; }
        /// <summary>
        /// 只写(选填), 群组最大成员数
        /// </summary>
        [JsonProperty("create_group_param_max_member_num")]
        public uint kTIMCreateGroupParamMaxMemberCount { set; get; }
        /// <summary>
        /// 只读(选填), 请参考[自定义字段]
        /// </summary>
        [JsonProperty("create_group_param_custom_info")]
        public List<GroupInfoCustemString> kTIMCreateGroupParamCustomInfo { set; get; }
    }
}
