using System;
using System.Runtime.InteropServices;
using TIMSDK.Core;
using TIMUtity;

namespace TIMSDK
{
    internal class TIMGlobalDef
    {
        /// <summary>
        /// 接口通用回调的定义
        /// </summary>
        /// <param name="code">值为 ERR_SUCC 表示成功，其他值表示失败</param>
        /// <param name="desc">错误描述字符串</param>
        /// <param name="jsonParams">JSON 字符串，不同的接口，JSON 字符串不一样</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMCommCallback(int code, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string desc,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string jsonParams, IntPtr userData);

        /// <summary>
        /// 新消息回调
        /// </summary>
        /// <param name="json_msg_array">新消息数组</param>
        /// <param name="userData">M SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMAddRecvNewMsgCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_msg_array, IntPtr userData);
        /// <summary>
        /// 删除接收新消息回调。
        /// </summary>
        /// <param name="json_msg_array"></param>
        /// <param name="userData"></param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMRemoveRecvNewMsgCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_msg_array, IntPtr userData);

        /// <summary>
        /// 消息已读回执回调
        /// </summary>
        /// <param name="json_msg_readed_receipt_array">消息已读回执数组</param>
        /// <param name="userData">M SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMMsgReadedReceiptCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_msg_readed_receipt_array, IntPtr userData);

        /// <summary>
        /// 接收的消息被撤回回调
        /// </summary>
        /// <param name="json_msg_locator_array">消息定位符数组</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMMsgRevokeCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_msg_locator_array, IntPtr userData);

        /// <summary>
        /// 消息内元素相关文件上传进度回调
        /// </summary>
        /// <param name="json_msg">新消息</param>
        /// <param name="index">上传Elem元素在json_msg消息的下标</param>
        /// <param name="cur_size">上传当前大小</param>
        /// <param name="total_size">上传总大小</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMMsgElemUploadProgressCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_msg,int index,int cur_size,int total_size, IntPtr userData);

        /// <summary>
        /// 群事件回调
        /// </summary>
        /// <param name="json_group_tip_array">群提示列表</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMGroupTipsEventCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_group_tip_array, IntPtr userData);

        /// <summary>
        /// 会话事件回调
        /// </summary>
        /// <param name="conv_event">会话事件类型</param>
        /// <param name="json_conv_array">会话信息列表</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMConvEventCallback(TIMConvEvent conv_event,[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_conv_array, IntPtr userData);

        /// <summary>
        /// 网络状态回调。
        /// </summary>
        /// <param name="status">网络状态</param>
        /// <param name="code">值为 ERR_SUCC 表示成功，其他值表示失败</param>
        /// <param name="desc">错误描述字符串</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMNetworkStatusListenerCallback(TIMNetworkStatus status,int code, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string desc, IntPtr userData);
        /// <summary>
        /// 被踢下线回调
        /// </summary>
        /// <param name="user_data">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMKickedOfflineCallback(IntPtr user_data);

        /// <summary>
        /// 用户票据过期回调。
        /// </summary>
        /// <param name="user_data">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMUserSigExpiredCallback(IntPtr user_data);
        /// <summary>
        /// 添加好友的回调
        /// </summary>
        /// <param name="json_identifier_array">添加好友列表</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMOnAddFriendCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_identifier_array, IntPtr userData);

        /// <summary>
        /// 删除好友的回调
        /// </summary>
        /// <param name="json_identifier_array">删除好友列表</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMOnDeleteFriendCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_identifier_array, IntPtr userData);

        /// <summary>
        /// 更新好友资料的回调
        /// </summary>
        /// <param name="json_friend_profile_update_array">好友资料更新列表</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMUpdateFriendProfileCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_friend_profile_update_array, IntPtr userData);
        /// <summary>
        /// 好友添加请求的回调
        /// </summary>
        /// <param name="json_friend_add_request_pendency_array">好友添加请求未决信息列表</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMFriendAddRequestCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_friend_add_request_pendency_array, IntPtr userData);

        /// <summary>
        /// 日志回调
        /// </summary>
        /// <param name="level">日志级别</param>
        /// <param name="log">日志字符串</param>
        /// <param name="userData">日志字符串</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMLogCallback(TIMLogLevel level,[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string log, IntPtr userData);

        /// <summary>
        /// 消息更新回调
        /// </summary>
        /// <param name="json_msg_array">更新的消息数组</param>
        /// <param name="userData">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TIMMsgUpdateCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_msg_array, IntPtr userData);
    }
}
