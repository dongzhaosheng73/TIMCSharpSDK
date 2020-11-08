using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    public enum TIMLogLevel
    {
        /// <summary>
        /// 关闭日志输出
        /// </summary>
        kTIMLog_Off = 0,
        /// <summary>
        /// 开发调试过程中一些详细信息日志
        /// </summary>
        kTIMLog_Verbose = 1,
        /// <summary>
        /// 调试日志
        /// </summary>
        kTIMLog_Debug = 2,
        /// <summary>
        /// 信息日志
        /// </summary>
        kTIMLog_Info = 3,
        /// <summary>
        /// 警告日志
        /// </summary>
        kTIMLog_Warn = 4,
        /// <summary>
        /// 错误日志
        /// </summary>
        kTIMLog_Error = 5,
        /// <summary>
        /// 断言日志
        /// </summary>
        kTIMLog_Assert6
    }
}
