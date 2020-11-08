using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK
{
    public enum TIMGroupMemberRole
    {
        /// <summary>
        ///  未定义
        /// </summary>
        kTIMMemberRole_None =0,
        /// <summary>
        /// 群成员
        /// </summary>
        kTIMMemberRole_Normal =1,
        /// <summary>
        /// 管理员
        /// </summary>
        kTIMMemberRole_Admin =2,
        /// <summary>
        /// 超级管理员（群主）
        /// </summary>
        kTIMMemberRole_Owner =3
    }
}
