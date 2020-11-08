using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// TIM接口返回值
    /// </summary>
    public enum TIMResult
    {
        /// <summary>
        /// 接口调用成功
        /// </summary>
        TIM_SUCC = 0,
        /// <summary>
        /// 接口调用失败，IM SDK 未初始化
        /// </summary>
        TIM_ERR_SDKUNINIT = -1,
        /// <summary>
        /// 接口调用失败，用户未登录
        /// </summary>
        TIM_ERR_NOTLOGIN = -2,
        /// <summary>
        /// 接口调用失败，错误的 JSON 格式或 JSON Key
        /// </summary>
        TIM_ERR_JSON = -3,
        /// <summary>
        /// 接口调用失败，参数错误
        /// </summary>
        TIM_ERR_PARAM = -4,
        /// <summary>
        /// 接口调用失败，无效的会话
        /// </summary>
        TIM_ERR_CONV = -5,
        /// <summary>
        /// 接口调用失败，无效的群组
        /// </summary>
        TIM_ERR_GROUP = -6
    }
}
