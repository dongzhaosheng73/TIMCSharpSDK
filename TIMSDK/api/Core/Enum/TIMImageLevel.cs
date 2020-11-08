using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    public enum TIMImageLevel
    {
        /// <summary>
        /// 原图发送
        /// </summary>
        kTIMImageLevel_Orig = 0,
        /// <summary>
        /// 高压缩率图发送（图片较小，默认值）
        /// </summary>
        kTIMImageLevel_Compression = 1,
        /// <summary>
        /// 高清图发送（图片较大）
        /// </summary>
        kTIMImageLevel_HD = 2
    }
}
