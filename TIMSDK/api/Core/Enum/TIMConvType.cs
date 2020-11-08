using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    public enum TIMConvType
    {
        /// <summary>
        /// 无效会话
        /// </summary>
        kTIMConv_Invalid = 0,
        /// <summary>
        /// 个人会话
        /// </summary>
        kTIMConv_C2C =1,
        /// <summary>
        /// 群组会话
        /// </summary>
        kTIMConv_Group =2,
        /// <summary>
        /// 系统会话
        /// </summary>
        kTIMConv_System =3
    }
}
