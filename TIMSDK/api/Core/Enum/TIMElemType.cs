using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TIMSDK.Enum
{
    public enum TIMElemType
    {
        /// <summary>
        /// 文本元素
        /// </summary>
        kTIMElem_Text = 0,
        /// <summary>
        /// 图片元素
        /// </summary>
        kTIMElem_Image = 1,
        /// <summary>
        /// 声音元素
        /// </summary>
        kTIMElem_Sound = 2,
        /// <summary>
        /// 自定义元素
        /// </summary>
        kTIMElem_Custom = 3,
        /// <summary>
        /// 文件元素
        /// </summary>
        kTIMElem_File = 4,
        /// <summary>
        /// 群组系统消息元素
        /// </summary>
        kTIMElem_GroupTips = 5,
        /// <summary>
        /// 表情元素
        /// </summary>
        kTIMElem_Face = 6,
        /// <summary>
        /// 位置元素
        /// </summary>
        kTIMElem_Location = 7,
        /// <summary>
        /// 群组系统通知元素
        /// </summary>
        kTIMElem_GroupReport = 8,
        /// <summary>
        /// 视频元素
        /// </summary>
        kTIMElem_Video = 9,
        /// <summary>
        /// 关系链变更消息元素
        /// </summary>
        kTIMElem_FriendChange = 10,
        /// <summary>
        /// 资料变更消息元素
        /// </summary>
        kTIMElem_ProfileChange = 11
    }
}
