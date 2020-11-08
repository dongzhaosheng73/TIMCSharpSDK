using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 群未决信息定义
    /// </summary>
    public class GroupPendency
    {
        /// <summary>
        /// 读写, 群组ID
        /// </summary>
        [JsonProperty("kTIMGroupPendencyGroupId")]
        public string kTIMGroupPendencyGroupId { set; get; }
        /// <summary>
        /// 读写, 请求者的ID,例如：请求加群:请求者,邀请加群:邀请人。
        /// </summary>
        [JsonProperty("group_pendency_form_identifier")]
        public string kTIMGroupPendencyFromIdentifier { set; get; }
        /// <summary>
        /// 读写, 判决者的ID,请求加群:"",邀请加群:被邀请人。
        /// </summary>
        [JsonProperty("group_pendency_to_identifier")]
        public string kTIMGroupPendencyToIdentifier { set; get; }
        /// <summary>
        /// 只读, 未决信息添加时间
        /// </summary>
        [JsonProperty("group_pendency_add_time")]
        public ulong kTIMGroupPendencyAddTime { set; get; }
        /// <summary>
        /// 只读, 未决请求类型
        /// </summary>
        [JsonProperty("group_pendency_pendency_type")]
        public TIMGroupPendencyType kTIMGroupPendencyPendencyType { set; get; }
        /// <summary>
        /// 只读, 群未决处理状态
        /// </summary>
        [JsonProperty("group_pendency_handled")]
        public TIMGroupPendencyHandle kTIMGroupPendencyHandled { set; get; }
        /// <summary>
        /// 只读, 群未决处理操作类型
        /// </summary>
        [JsonProperty("group_pendency_handle_result")]
        public TIMGroupPendencyHandleResult kTIMGroupPendencyHandleResult { set; get; }
        /// <summary>
        /// 只读, 申请或邀请附加信息
        /// </summary>
        [JsonProperty("group_pendency_apply_invite_msg")]
        public string kTIMGroupPendencyApplyInviteMsg { set; get; }
        /// <summary>
        /// 只读, 申请或邀请者自定义字段
        /// </summary>
        [JsonProperty("group_pendency_form_user_defined_data")]
        public string kTIMGroupPendencyFromUserDefinedData { set; get; }
        /// <summary>
        ///  只读, 审批信息：同意或拒绝信息
        /// </summary>
        [JsonProperty("group_pendency_approval_msg")]
        public string kTIMGroupPendencyApprovalMsg { set; get; }
        /// <summary>
        /// 只读, 审批者自定义字段
        /// </summary>
        [JsonProperty("group_pendency_to_user_defined_data")]
        public string kTIMGroupPendencyToUserDefinedData { set; get; }
        /// <summary>
        /// 只读, 签名信息，客户不用关心
        /// </summary>
        [JsonProperty("group_pendency_key")]
        public string kTIMGroupPendencyKey { set; get; }
        /// <summary>
        /// 只读, 签名信息，客户不用关心
        /// </summary>
        [JsonProperty("group_pendency_authentication")]
        public string kTIMGroupPendencyAuthentication { set; get; }
        /// <summary>
        /// 只读, 自己的ID
        /// </summary>
        [JsonProperty("group_pendency_self_identifier")]
        public string kTIMGroupPendencySelfIdentifier { set; get; }
    }
}
