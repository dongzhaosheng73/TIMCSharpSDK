using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIMSDK.API.Core.Enum;

namespace TIMSDK.Model
{
    /// <summary>
    /// 获取群组成员信息的选项。
    /// </summary>
    public class GroupMemberGetInfoOption
    {
        /// <summary>
        /// 根据想要获取的信息过滤，默认值为 0xffffffff（获取全部信息）
        /// </summary>
        [JsonProperty("group_member_get_info_option_info_flag")]
        public TIMGroupMemberInfoFlag kTIMGroupMemberGetInfoOptionInfoFlag { set; get; }
        /// <summary>
        /// 根据成员角色过滤，默认值为 kTIMGroupMemberRoleFlag_All，获取所有角色
        /// </summary>
        [JsonProperty("group_member_get_info_option_role_flag")]
        public TIMGroupMemberRoleFlag kTIMGroupMemberGetInfoOptionRoleFlag { set; get; }
        /// <summary>
        /// 请参考 自定义字段
        /// </summary>
        [JsonProperty("group_member_get_info_option_custom_array")]
        public List<string> kTIMGroupMemberGetInfoOptionCustomArray { set; get; }
    }
}
