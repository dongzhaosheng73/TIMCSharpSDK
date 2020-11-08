using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Model
{
    public class SdKConfig
    {
        /// <summary>
        /// 配置文件路径，默认路径为"/"
        /// </summary>
        ///
        [JsonProperty("sdk_config_config_file_path")]
        public string kTIMSdkConfigConfigFilePath { set; get; }
        /// <summary>
        /// 日志文件路径，默认路径为"/"
        /// </summary>
        /// 
        [JsonProperty("sdk_config_log_file_path")]
        public string kTIMSdkConfigLogFilePath { set; get; }
    }
}
