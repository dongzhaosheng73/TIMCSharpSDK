using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 群组内本人的信息
    /// </summary>
    public class GroupSelfInfo
    {
        /// <summary>
        /// 加入群组时间
        /// </summary>
        [JsonProperty("group_self_info_join_time")]
        public uint kTIMGroupSelfInfoJoinTime { set; get; }
        /// <summary>
        /// 用户在群组中的角色
        /// </summary>
        [JsonProperty("group_self_info_role")]
        public uint kTIMGroupSelfInfoRole { set; get; }
        /// <summary>
        /// 消息未读计数
        /// </summary>
        [JsonProperty("group_self_info_unread_num")]
        public uint kTIMGroupSelfInfoUnReadNum { set; get; }
        /// <summary>
        ///  群消息接收选项
        /// </summary>
        [JsonProperty("group_self_info_msg_flag")]
        public TIMGroupReceiveMessageOpt kTIMGroupSelfInfoMsgFlag { set; get; }
    }
}
