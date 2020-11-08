using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 获取已加入群组列表接口的返回（群组基础信息）。
    /// </summary>
    public class GroupBaseInfo
    {
        [JsonProperty("group_base_info_group_id")]
        public string kTIMGroupBaseInfoGroupId { set; get; }
        [JsonProperty("group_base_info_group_name")]
        public string kTIMGroupBaseInfoGroupName { set; get; }
        [JsonProperty("group_base_info_group_type")]
        public TIMGroupType kTIMGroupBaseInfoGroupType { set; get; }
        [JsonProperty("group_base_info_face_url")]
        public string kTIMGroupBaseInfoFaceUrl { set; get; }
        [JsonProperty("group_base_info_info_seq")]
        public uint kTIMGroupBaseInfoInfoSeq { set; get; }
        [JsonProperty("group_base_info_lastest_seq")]
        public uint kTIMGroupBaseInfoLastestSeq { set; get; }
        [JsonProperty("group_base_info_readed_seq")]
        public uint kTIMGroupBaseInfoReadedSeq { set; get; }
        [JsonProperty("group_base_info_msg_flag")]
        public uint kTIMGroupBaseInfoMsgFlag { set; get; }
        [JsonProperty("group_base_info_is_shutup_all")]
        public bool kTIMGroupBaseInfoIsShutupAll { set; get; }
        [JsonProperty("group_base_info_self_info")]
        public GroupSelfInfo kTIMGroupBaseInfoSelfInfo { set; get; }

    }
}
