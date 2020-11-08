using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 获取用户资料参数
    /// </summary>
    public class GetProfileListParam
    {
        /// <summary>
        /// 只写, 是否强制更新。false表示优先从本地缓存获取，获取不到则去网络上拉取。true表示直接去网络上拉取资料。默认值为false
        /// </summary>
        [JsonProperty("friendship_getprofilelist_param_force_update")]
        public bool kTIMFriendShipGetProfileListParamForceUpdate { set; get; }
        /// <summary>
        /// 只写, 想要获取目标用户资料的identifier列表
        /// </summary>
        [JsonProperty("friendship_getprofilelist_param_identifier_array")]
        public List<string> kTIMFriendShipGetProfileListParamIdentifierArray { set; get; }
    }
}
