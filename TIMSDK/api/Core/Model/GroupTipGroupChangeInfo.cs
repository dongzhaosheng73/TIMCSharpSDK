using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class GroupTipGroupChangeInfo
    {
        /// <summary>
        /// 只读, 群消息修改群信息标志
        /// </summary>
        [JsonProperty("group_tips_group_change_info_flag")]
        public TIMGroupTipGroupChangeFlag kTIMGroupTipGroupChangeInfoFlag { set; get; }
        /// <summary>
        /// 修改的后值,不同的 info_flag 字段,具有不同的含义
        /// </summary>
        [JsonProperty("group_tips_group_change_info_value")]
        public string kTIMGroupTipGroupChangeInfoValue { set; get; }
    }
}
