using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TIMUtity;
using static TIMSDK.TIMGlobalDef;

namespace TIMSDK.Core.Client
{
    internal static class TIMClientAPIDef
    {
        #region api
        #region 初始化相关
        /// <summary>
        /// IM SDK初始化
        /// </summary>
        /// <param name="sdk_app_id">app_id</param>
        /// <param name="json_sdk_config">IM SDK 配置</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMInit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMInit(ulong sdk_app_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string json_sdk_config);
        /// <summary>
        /// IM SDK 卸载
        /// </summary>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMUninit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMUninit();
        /// <summary>
        /// 获取 IM SDK 版本信息
        /// </summary>
        /// <returns></returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGetSDKVersion", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern string TIMGetSDKVersion();
        #endregion

        #region 登录登出
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user_id">用户的UserID</param>
        /// <param name="user_sig">用户的UserSig</param>
        /// <param name="cb">登录成功与否回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMLogin", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMLogin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string user_id,
        [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string user_sig, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="cb">登录成功与否回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMLogout", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMLogout(TIMCommCallback cb, IntPtr user_data);
        #endregion

        #region 会话相关接口
        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="cb">创建会话回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMConvCreate", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMConvCreate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="cb">删除会话成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMConvDelete", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMConvDelete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取最近联系人的会话列表。
        /// </summary>
        /// <param name="cb">获取最近联系人会话列表的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMConvGetConvList", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMConvGetConvList(TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置指定会话的草稿
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_draft_param">被设置的草稿 JSON 字符串</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMConvSetDraft", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMConvSetDraft([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_draft_param);
        /// <summary>
        /// 删除指定会话的草稿
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="conv_type">会话类型</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMConvCancelDraft", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMConvCancelDraft([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type);

        #endregion

        #region 消息相关接口
        /// <summary>
        /// 发送新消息，单聊消息和群消息的发送均采用此接口。
        ///发送单聊消息时conv_id为对方的 UserID，conv_type为kTIMConv_C2C。
        ///发送群聊消息时conv_id为群 ID，conv_type为kTIMConv_Group。
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_msg_param">发送的消息json字符串</param>
        /// <param name="cb">发送新消息成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgSendNewMsg", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgSendNewMsg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_msg_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 消息上报已读
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_msg_param">消息 JSON 字符串</param>
        /// <param name="cb">消息上报已读成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgReportReaded", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgReportReaded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_msg_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 消息撤回
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_msg_param">消息 JSON 字符串</param>
        /// <param name="cb">消息撤回成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgRevoke", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgRevoke([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_msg_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 根据消息定位精准查找指定会话的消息。
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_msg_Locator_array">消息定位符数组</param>
        /// <param name="cb">根据消息定位精准查找指定会话的消息成功与否的回调。回调函数定义和参数解析请参考</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgFindByMsgLocatorList", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgFindByMsgLocatorList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_msg_Locator_array, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 导入消息列表到指定会话
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_msg_array">消息数组</param>
        /// <param name="cb">导入消息列表到指定会话成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgImportMsgList", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgImportMsgList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_msg_array, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 保存自定义消息
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_msg_param">消息 JSON 字符串</param>
        /// <param name="cb">保存自定义消息成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgSaveMsg", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgSaveMsg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_msg_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取指定会话的消息列表。
        /// 从kTIMMsgGetMsgListParamLastMsg指定的消息开始获取本地消息列表，kTIMMsgGetMsgListParamCount 为要获取的消息数目。
        /// kTIMMsgGetMsgListParamLastMsg 可以不指定，不指定时表示以会话最新的消息为 LastMsg。
        /// 若指定kTIMMsgGetMsgListParamIsRamble为 true 则本地消息获取不够指定数目时，会去获取云端漫游消息。
        /// kTIMMsgGetMsgListParamIsForward为 true 时表示获取比kTIMMsgGetMsgListParamLastMsg新的消息，为 false 时表示获取比kTIMMsgGetMsgListParamLastMsg旧的消息。
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_get_msg_param">消息 JSON 字符串</param>
        /// <param name="cb">获取指定会话的消息列表成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgGetMsgList", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgGetMsgList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_get_msg_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 删除指定会话的消息
        /// </summary>
        /// <param name="conv_id">会话的id</param>
        /// <param name="conv_type">会话类型</param>
        /// <param name="json_msgdel_param">消息获取参数</param>
        /// <param name="cb">删除指定会话的消息成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgDelete", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgDelete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string conv_id, TIMConvType conv_type,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_msgdel_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 下载消息内元素到指定文件路径（图片、视频、音频、文件）。
        /// </summary>
        /// <param name="json_download_elem_param">下载的参数 JSON 字符串</param>
        /// <param name="path">下载文件保存路径</param>
        /// <param name="cb">下载成功与否的回调以及下载进度回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgDownloadElemToPath", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgDownloadElemToPath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_download_elem_param,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string path, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 群发消息
        /// 批量发送消息的接口，每个 UserID 发送成功与否，通过回调 cb 返回。
        /// </summary>
        /// <param name="json_batch_send_param">群发消息 JSON 字符串</param>
        /// <param name="cb">群发消息成功与否的回调。</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>TIMResult TIM_SUCC 表示成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMMsgBatchSend", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int TIMMsgBatchSend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_batch_send_param, TIMCommCallback cb, IntPtr user_data);

        #endregion

        #region 群组相关接口
        /// <summary>
        /// 创建群组
        /// 创建群组时可以指定群 ID，若未指定时 IM 通讯云服务器会生成一个唯一的 ID，以便后续操作，群组 ID 通过创建群组时传入的回调返回
        /// 创建群参数的 JSON Key 详情请参考 CreateGroupParam。
        /// </summary>
        /// <param name="json_group_create_param">创建群组的参数 JSON 字符串</param>
        /// <param name="cb">创建群组成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupCreate", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupCreate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_create_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 删除（解散）群组
        /// 对于私有群，任何人都无法解散群组。
        /// 对于公开群、聊天室和直播大群，群主可以解散群组。
        /// </summary>
        /// <param name="group_id">	要删除的群组 ID</param>
        /// <param name="cb">删除群组成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupDelete", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupDelete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string group_id, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 申请加入群组
        /// </summary>
        /// <param name="group_id">要加入的群组 ID</param>
        /// <param name="hello_msg">申请理由（选填）</param>
        /// <param name="cb">申请加入群组成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupJoin", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupJoin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string group_id,
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))] string hello_msg, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 退出群组
        /// </summary>
        /// <param name="group_id">要退出的群组 ID</param>
        /// <param name="cb">退出群组成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupQuit", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupQuit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string group_id, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 邀请加入群组
        /// </summary>
        /// <param name="json_group_invite_param">邀请加入群组的 JSON 字符串</param>
        /// <param name="cb">邀请加入群组成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupInviteMember", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupInviteMember([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_invite_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 删除群组成员。
        /// </summary>
        /// <param name="json_group_delete_param">删除群组成员的 JSON 字符串</param>
        /// <param name="cb">删除群组成员成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupDeleteMember", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupDeleteMember([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_delete_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取已加入群组列表
        /// </summary>
        /// <param name="cb">获取已加入群组列表成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupGetJoinedGroupList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupGetJoinedGroupList(TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取群组信息列表
        /// </summary>
        /// <param name="json_group_getinfo_param">获取群组信息列表参数的 JSON 字符串</param>
        /// <param name="cb">获取群组信息列表成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupGetGroupInfoList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupGetGroupInfoList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_getinfo_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 修改群信息
        /// </summary>
        /// <param name="json_group_modifyinfo_param">设置群信息参数的 JSON 字符串 JSON 字符串</param>
        /// <param name="cb">设置群信息成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupModifyGroupInfo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupModifyGroupInfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_modifyinfo_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取群成员信息列表
        /// </summary>
        /// <param name="json_group_getmeminfos_param">获取群成员信息列表参数的 JSON 字符串</param>
        /// <param name="cb">获取群成员信息列表成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupGetMemberInfoList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupGetMemberInfoList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_getmeminfos_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 修改群成员信息
        /// </summary>
        /// <param name="json_group_modifymeminfo_param">设置群信息参数的 JSON 字符串</param>
        /// <param name="cb">设置群成员信息成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupModifyMemberInfo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupModifyMemberInfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_modifymeminfo_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取群未决信息列表群未决信息是指还没有处理的操作，例如，邀请加群或者请求加群操作还没有被处理，称之为群未决信息。
        /// </summary>
        /// <param name="json_group_getpendence_list_param">设置群未决信息参数的 JSON 字符串</param>
        /// <param name="cb">获取群未决信息列表成功与否的回调。回调函数定义和参数解析请参考</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupGetPendencyList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupGetPendencyList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_getpendence_list_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 上报群未决信息已读
        /// </summary>
        /// <param name="time_stamp">已读时间戳（单位秒）</param>
        /// <param name="cb">上报群未决信息已读成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupReportPendencyReaded", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupReportPendencyReaded(ulong time_stamp, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 处理群未决信息
        /// </summary>
        /// <param name="json_group_handle_pendency_param">处理群未决信息参数的 JSON 字符串</param>
        /// <param name="cb">处理群未决信息成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMGroupHandlePendency", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMGroupHandlePendency([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_group_handle_pendency_param, TIMCommCallback cb, IntPtr user_data);
        #endregion

        #region 用户资料相关接口
        /// <summary>
        /// 获取指定用户列表的个人资料
        /// </summary>
        /// <param name="json_get_user_profile_list_param">获取指定用户列表的用户资料接口参数的 JSON 字符串</param>
        /// <param name="cb">获取指定用户列表的用户资料成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMProfileGetUserProfileList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMProfileGetUserProfileList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_get_user_profile_list_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 修改自己的个人资料
        /// </summary>
        /// <param name="json_modify_self_user_profile_param">修改自己的资料接口参数的 JSON 字符串</param>
        /// <param name="cb">修改自己的资料成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMProfileModifySelfUserProfile", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMProfileModifySelfUserProfile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_modify_self_user_profile_param, TIMCommCallback cb, IntPtr user_data);
        #endregion

        #region  关系链相关接口
        /// <summary>
        /// 获取好友列表
        /// </summary>
        /// <param name="cb">获取好友列表成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipGetFriendProfileList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipGetFriendProfileList(TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 添加好友
        /// </summary>
        /// <param name="json_add_friend_param">添加好友接口参数的 JSON 字符串</param>
        /// <param name="cb">添加好友成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipAddFriend", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipAddFriend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_add_friend_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 处理好友请求
        /// </summary>
        /// <param name="json_handle_friend_add_param">处理好友请求接口参数的 JSON 字符串</param>
        /// <param name="cb">处理好友请求成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipHandleFriendAddRequest", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipHandleFriendAddRequest([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_handle_friend_add_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 更新好友资料（备注等）
        /// </summary>
        /// <param name="json_modify_friend_info_param">更新好友资料接口参数的 JSON 字符串</param>
        /// <param name="cb">更新好友资料成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipModifyFriendProfile", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipModifyFriendProfile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_modify_friend_info_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="json_delete_friend_param">删除好友接口参数的 JSON 字符串</param>
        /// <param name="cb">删除好友成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipDeleteFriend", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipDeleteFriend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_delete_friend_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 检测好友类型（单向或双向）
        /// </summary>
        /// <param name="json_check_friend_list_param">检测好友接口参数的 JSON 字符串</param>
        /// <param name="cb">检测好友成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipCheckFriendType", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipCheckFriendType([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_check_friend_list_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 创建好友分组
        /// </summary>
        /// <param name="json_create_friend_group_param">创建好友分组接口参数的 JSON 字符串</param>
        /// <param name="cb">创建好友分组成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipCreateFriendGroup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipCreateFriendGroup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_create_friend_group_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取指定好友分组的分组信息。
        /// </summary>
        /// <param name="json_get_friend_group_list_param">获取好友分组信息接口参数的 JSON 字符串</param>
        /// <param name="cb">获取好友分组信息成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipGetFriendGroupList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipGetFriendGroupList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_get_friend_group_list_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 修改好友分组
        /// </summary>
        /// <param name="json_modify_friend_group_param">修改好友分组接口参数的 JSON 字符串</param>
        /// <param name="cb">修改好友分组成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipModifyFriendGroup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipModifyFriendGroup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_modify_friend_group_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 删除好友分组
        /// </summary>
        /// <param name="json_delete_friend_group_param">删除好友分组接口参数的 JSON 字符串</param>
        /// <param name="cb">删除好友分组成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipDeleteFriendGroup", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipDeleteFriendGroup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_delete_friend_group_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 添加指定用户到黑名单
        /// </summary>
        /// <param name="json_add_to_blacklist_param">添加指定用户到黑名单接口参数的 JSON 字符串</param>
        /// <param name="cb">添加指定用户到黑名单成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipAddToBlackList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipAddToBlackList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_add_to_blacklist_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取黑名单列表
        /// </summary>
        /// <param name="cb">获取黑名单列表成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipGetBlackList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipGetBlackList(TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 从黑名单中删除指定用户列表
        /// </summary>
        /// <param name="json_delete_from_blacklist_param">从黑名单中删除指定用户接口参数的 JSON 字符串</param>
        /// <param name="cb">从黑名单中删除指定用户成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipDeleteFromBlackList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipDeleteFromBlackList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_delete_from_blacklist_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 获取好友添加请求未决信息列表
        /// </summary>
        /// <param name="json_get_pendency_list_param">获取未决列表接口参数的 JSON 字符串</param>
        /// <param name="cb">获取未决列表成功与否的回调</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功</returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipGetPendencyList", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipGetPendencyList([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_get_pendency_list_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 删除指定好友添加请求未决信息
        /// </summary>
        /// <param name="json_delete_pendency_param">删除指定未决信息接口参数的 JSON 字符串</param>
        /// <param name="cb">删除指定未决信息成功与否的回调。</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns></returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipDeletePendency", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipDeletePendency([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(Utf8StringMarshaler))]string json_delete_pendency_param, TIMCommCallback cb, IntPtr user_data);
        /// <summary>
        /// 上报好友添加请求未决信息已读
        /// </summary>
        /// <param name="time_stamp">上报未决信息已读时间戳</param>
        /// <param name="cb">上报未决信息已读用户成功与否的回调。</param>
        /// <param name="user_data">用户自定义数据</param>
        /// <returns></returns>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMFriendshipReportPendencyReaded", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern int TIMFriendshipReportPendencyReaded(ulong time_stamp, TIMCommCallback cb, IntPtr user_data);
        #endregion

        #region 事件回调接口
        /// <summary>
        /// 增加接收新消息回调
        /// 如果用户是登录状态，IM SDK 收到新消息会通过此接口设置的回调抛出，另外需要注意，抛出的消息不一定是未读的消息，
        /// 只是本地曾经没有过的消息（例如在另外一个终端已读，拉取最近联系人消息时可以获取会话最后一条消息，如果本地没有，会通过此方法抛出）。
        /// 在用户登录之后，IM SDK 会拉取离线消息，为了不漏掉消息通知，需要在登录之前注册新消息通知。
        /// </summary>
        /// <param name="cb">新消息回调函数</param>
        /// <param name="user_data">用户自定义数据</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMAddRecvNewMsgCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMAddRecvNewMsgCallback(TIMAddRecvNewMsgCallback cb, IntPtr user_data);
        /// <summary>
        /// 删除接收新消息回调
        /// </summary>
        /// <param name="cb">新消息回调函数 参数 cb 需要跟 TIMAddRecvNewMsgCallback 传入的 cb 一致，否则删除回调失败</param>
        /// <param name="user_data">用户自定义数据</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMRemoveRecvNewMsgCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMRemoveRecvNewMsgCallback(TIMRemoveRecvNewMsgCallback cb,IntPtr user_data);
        /// <summary>
        /// 设置消息已读回执回调
        /// </summary>
        /// <param name="cb">消息已读回执回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetMsgReadedReceiptCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetMsgReadedReceiptCallback(TIMMsgReadedReceiptCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置接收的消息被撤回回调
        /// </summary>
        /// <param name="cb">消息撤回通知回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetMsgRevokeCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetMsgRevokeCallback(TIMMsgRevokeCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置消息内元素相关文件上传进度回调
        /// 设置消息元素上传进度回调。当消息内包含图片、声音、文件、视频元素时，IM SDK 会上传这些文件，并触发此接口设置的回调，用户可以根据回调感知上传的进度。
        /// </summary>
        /// <param name="cb">文件上传进度回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetMsgElemUploadProgressCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetMsgElemUploadProgressCallback(TIMMsgElemUploadProgressCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置群组系统消息回调
        /// 群组系统消息事件包括加入群、退出群、踢出群、设置管理员、取消管理员、群资料变更、群成员资料变更。此消息是针对所有群组成员下发的。
        /// </summary>
        /// <param name="cb">群消息回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetGroupTipsEventCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetGroupTipsEventCallback(TIMGroupTipsEventCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置会话事件回调
        /// 会话事件包括：会话新增\会话删除\会话更新
        /// </summary>
        /// <param name="cb">会话事件回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetConvEventCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetConvEventCallback(TIMConvEventCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置网络连接状态监听回调 仅指明 IM SDK 是否与即时通信 IM 云 Server 连接状态
        /// </summary>
        /// <param name="cb">连接事件回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetNetworkStatusListenerCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetNetworkStatusListenerCallback(TIMNetworkStatusListenerCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置被踢下线通知回调
        /// </summary>
        /// <param name="cb">踢下线回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetKickedOfflineCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetKickedOfflineCallback(TIMKickedOfflineCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置票据过期回调
        /// </summary>
        /// <param name="cb">票据过期回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetUserSigExpiredCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetUserSigExpiredCallback(TIMUserSigExpiredCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置添加好友的回调
        /// </summary>
        /// <param name="cb">添加好友回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetOnAddFriendCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetOnAddFriendCallback(TIMOnAddFriendCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置删除好友的回调
        /// </summary>
        /// <param name="cb">删除好友回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetOnDeleteFriendCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetOnDeleteFriendCallback(TIMOnDeleteFriendCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置更新好友资料的回调。
        /// </summary>
        /// <param name="cb">更新好友资料回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMUpdateFriendProfileCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMUpdateFriendProfileCallback(TIMUpdateFriendProfileCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置好友添加请求的回调
        /// </summary>
        /// <param name="cb">好友添加请求回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetFriendAddRequestCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetFriendAddRequestCallback(TIMFriendAddRequestCallback cb, IntPtr user_data);
        /// <summary>
        /// 设置日志回调
        /// </summary>
        /// <param name="cb">日志回调</param>
        /// <param name="user_data">用户自定义数据，IM SDK 只负责传回给回调函数 cb，不做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetLogCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetLogCallback(TIMLogCallback cb, IntPtr user_data);
        /// <summary>
        /// 消息更新回调
        /// </summary>
        /// <param name="cb">更新的消息数组</param>
        /// <param name="user_data">IM SDK 负责透传的用户自定义数据，未做任何处理</param>
        [DllImport(@"imsdk.dll", EntryPoint = "TIMSetMsgUpdateCallback", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal static extern void TIMSetMsgUpdateCallback(TIMMsgUpdateCallback cb, IntPtr user_data);
        #endregion

        #endregion
    }
}
