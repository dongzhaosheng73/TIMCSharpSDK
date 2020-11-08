using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 获取群未决信息列表的参数
    /// </summary>
    public class GetGroupPendencyParam
    {
        /// <summary>
        /// 只写(必填), 设置拉取时间戳,第一次请求填0,后边根据server返回的[GroupPendencyResult]()键kTIMGroupPendencyResultNextStartTime指定的时间戳进行填写
        /// </summary>
        [JsonProperty("group_pendency_option_start_time")]
        public ulong kTIMGroupPendencyOptionStartTime { set; get;}
        /// <summary>
        /// 只写(选填), 拉取的建议数量,server可根据需要返回或多或少,不能作为完成与否的标志
        /// </summary>
        [JsonProperty("group_pendency_option_max_limited")]
        public uint kTIMGroupPendencyOptionMaxLimited { set; get; }
    }
}
