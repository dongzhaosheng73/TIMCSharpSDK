using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 创建群组接口的返回。
    /// </summary>
    public class CreateGroupResult
    {
        /// <summary>
        /// 创建的群 ID
        /// </summary>
        [JsonProperty("kTIMCreateGroupResultGroupId")]
        public string kTIMCreateGroupResultGroupId { set; get; }
    }
}
