using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class DownloadElemParam
    {
        [JsonProperty("msg_download_elem_param_flag")]
        public uint kTIMMsgDownloadElemParamFlag { set; get; }
        [JsonProperty("msg_download_elem_param_type")]
        public TIMDownloadType kTIMMsgDownloadElemParamType { set; get; }
        [JsonProperty("msg_download_elem_param_id")]
        public string kTIMMsgDownloadElemParamId { set; get; }
        [JsonProperty("msg_download_elem_param_business_id")]
        public uint kTIMMsgDownloadElemParamBusinessId { set; get; }
        [JsonProperty("msg_download_elem_param_url")]
        public string kTIMMsgDownloadElemParamUrl { set; get; }
    }
}
