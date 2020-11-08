using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 获取群成员列表接口的返回
    /// </summary>
    public class GroupGetMemberInfoListResult
    {
        /// <summary>
        ///  只读, 下一次拉取的标志,server返回0表示没有更多的数据,否则在下次获取数据时填入这个标志
        /// </summary>
        [JsonProperty("group_get_memeber_info_list_result_next_seq")]
        public ulong kTIMGroupGetMemberInfoListResultNexSeq { set; get; }
        /// <summary>
        /// 只读, 成员信息列表
        /// </summary>
        [JsonProperty("group_get_memeber_info_list_result_info_array")]
        public List<GroupMemberInfo> kTIMGroupGetMemberInfoListResultInfoArray { set; get; }
    }
}
