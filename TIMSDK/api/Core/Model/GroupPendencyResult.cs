using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 获取群未决信息列表的返回
    /// </summary>
    public class GroupPendencyResult
    {
        /// <summary>
        ///  只读, 下一次拉取的起始时戳,server返回0表示没有更多的数据,否则在下次获取数据时以这个时间戳作为开始时间戳
        /// </summary>
        [JsonProperty("group_pendency_result_next_start_time")]
        public ulong kTIMGroupPendencyResultNextStartTime { set; get; }
        /// <summary>
        /// 只读, 已读上报的时间戳
        /// </summary>
        [JsonProperty("group_pendency_result_read_time_seq")]
        public ulong kTIMGroupPendencyResultReadTimeSeq { set; get; }
        /// <summary>
        ///   只读, 未决请求的未读数 
        /// </summary>
        [JsonProperty("group_pendency_result_unread_num")]
        public uint kTIMGroupPendencyResultUnReadNum { set; get; }
        /// <summary>
        /// 只读, 群未决信息列表
        /// </summary>
        [JsonProperty("group_pendency_result_pendency_array")]
        public GroupPendency kTIMGroupHandlePendencyParamPendency { set; get; }
    }
}
