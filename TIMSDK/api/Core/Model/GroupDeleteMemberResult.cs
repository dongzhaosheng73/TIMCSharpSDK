using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 删除成员接口的返回
    /// </summary>
    public class GroupDeleteMemberResult
    {
        /// <summary>
        /// 删除的成员ID
        /// </summary>
        [JsonProperty("group_delete_member_result_identifier")]
        public string kTIMGroupDeleteMemberResultIdentifier { set; get; }
        /// <summary>
        /// 删除结果
        /// </summary>
        [JsonProperty("group_delete_member_result_result")]
        public TIMHandleGroupMemberResult kTIMGroupDeleteMemberResultResult { set; get; }
    }
}
