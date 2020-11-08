using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 获取群成员列表接口的参数。
    /// </summary>
    public class GroupGetMemberInfoListParam
    {
        /// <summary>
        /// 群组 ID
        /// </summary>
        [JsonProperty("group_get_members_info_list_param_group_id")]
        public string kTIMGroupGetMemberInfoListParamGroupId { set; get; }
        /// <summary>
        /// 群成员 ID 列表
        /// </summary>
        [JsonProperty("group_get_members_info_list_param_identifier_array")]
        public List<string> kTIMGroupGetMemberInfoListParamIdentifierArray { set; get; }
        /// <summary>
        /// 获取群成员信息的选项
        /// </summary>
        [JsonProperty("group_get_members_info_list_param_option")]
        public GroupMemberGetInfoOption kTIMGroupGetMemberInfoListParamOption { set; get; }
        /// <summary>
        /// 分页拉取标志，第一次拉取填0，回调成功如果不为零，需要分页，调用接口传入再次拉取，直至为0
        /// </summary>
        [JsonProperty("group_get_members_info_list_param_next_seq")]
        public ulong kTIMGroupGetMemberInfoListParamNextSeq { set; get; }
    }
}
