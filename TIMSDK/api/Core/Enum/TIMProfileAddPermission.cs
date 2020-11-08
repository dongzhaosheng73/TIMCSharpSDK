using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    /// <summary>
    /// 用户加好友的选项
    /// </summary>
    public enum TIMProfileAddPermission
    {
        /// <summary>
        /// 未知
        /// </summary>
        kTIMProfileAddPermission_Unknown = 0,
        /// <summary>
        /// 允许任何人添加好友
        /// </summary>
        kTIMProfileAddPermission_AllowAny = 1,
        /// <summary>
        /// 添加好友需要验证
        /// </summary>
        kTIMProfileAddPermission_NeedConfirm = 2,
        /// <summary>
        /// 拒绝任何人添加好友
        /// </summary>
        kTIMProfileAddPermission_DenyAny = 3
    }
}
