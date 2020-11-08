using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// UUID 类型。
    /// </summary>
    public enum TIMDownloadType
    {
        /// <summary>
        /// 视频缩略图
        /// </summary>
        kTIMDownload_VideoThumb = 0,
        /// <summary>
        /// 文件
        /// </summary>
        kTIMDownload_File = 1,
        /// <summary>
        /// 视频
        /// </summary>
        kTIMDownload_Video = 2,
        /// <summary>
        /// 声音
        /// </summary>
        kTIMDownload_Sound = 3
    }
}
