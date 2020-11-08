using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    /// <summary>
    /// 下载元素接口的返回
    /// </summary>
    public class MsgDownloadElemResult
    {
        [JsonProperty("msg_download_elem_result_current_size")]
        public uint kTIMMsgDownloadElemResultCurrentSize { set; get; }
        [JsonProperty("msg_download_elem_result_total_size")]
        public uint kTIMMsgDownloadElemResultTotalSize { set; get; }
    }
}
