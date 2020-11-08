using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIMSDK.Model;
using TIMUtity;

namespace TIMSDK.Core.Client
{
    public class TIMClient
    {
        #region Delegate
        public delegate void LoginResultDelegate(IMResult loginResult);

        public delegate void LogoutResultDelgate(IMResult logoutResult);

        public delegate void ConvCreateDelgate(IMConvCreateResult convCreateResult);

        public delegate void ConvDeleteDelgate(IMResult convDeleteResult);

        public delegate void ConvGetConvListDelgate(IMConvGetConvListResult convGetConvListResult);

        public delegate void MsgSendNewMsgDelgate(IMMsgResult msgSendNewMsgResult);

        public delegate void MsgReportReadedDelgate(IMResult msgReportReadedResult);

        public delegate void MsgRevokeDelgate(IMResult msgRevokeResult);

        public delegate void MsgFindByMsgLocatorListDelgate(IMMsgArrayResult msgArrayResult);

        public delegate void MsgImportMsgListDelgate(IMResult msgImportMsgListResult);

        public delegate void MsgSaveMsgDelgate(IMResult msgSaveMsgResult);

        public delegate void MsgGetMsgListDelgate(IMMsgArrayResult msgArrayResult);

        public delegate void MsgDeleteDelgate(IMResult msgDeleteResult);

        public delegate void MsgDownloadElemToPathDelgate(IMDownloadElemResult msgDownloadResult);

        public delegate void MsgBatchSendDelgate(IMMsgBatchSendResult msgBatchSendResult);

        public delegate void GroupCreateDelgate(IMCreateGroupResult createGroupResult);

        public delegate void GroupDeleteDelgate(IMResult groupDeleteResult);

        public delegate void GroupJoinDelgate(IMResult groupJoinResult);

        public delegate void GroupQuitDelegate(IMResult groupQuitResult);

        public delegate void GroupInviteMemberDelegate(IMGroupInviteMemberResult groupInviteResult);

        public delegate void GroupDeleteMemberDelegate(IMGroupDeleteMemberResult groupDeleteMemberResult);

        public delegate void GroupGetJoinedGroupListDelegate(IMGroupBaseInfoResult groupBaseInfoResult);

        public delegate void GroupGetGroupInfoListDelegate(IMGroupGetGroupInfoListResult groupGetGroupInfoListResult);

        public delegate void GroupModifyGroupInfoDelegate(IMResult groupModifyGroupInfoResult);

        public delegate void GroupGetMemberInfoListResultDelegate(IMGroupGetMemberInfoListResult groupGetMemberInfoListResult);

        public delegate void GroupModifyMemberInfoDelegate(IMResult groupModifyMemberInfoResult);

        public delegate void GroupGetPendencyListDelegate(IMGroupPendencyResult groupPendencyResult);

        public delegate void GroupReportPendencyReadedDelegate(IMResult groupReportPendencyReadedResult);

        public delegate void GroupHandlePendencyDelegate(IMResult groupHandlePendencyResult);

        public delegate void UserProfileHandleDelegate(IMUserProfileResult userProfileResult);
        #endregion

        #region CallBackEvent
        /// <summary>
        /// 登录回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback LoginResultCallBack = OnLoginResultCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnLoginResultCallback(int code,string desc, string jsonResult, IntPtr ptr)
        {
            if(ptr != IntPtr.Zero)
            {
                ptr.Invoke<LoginResultDelegate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }          
        }
        /// <summary>
        /// 登出回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback LogoutResultCallBack = OnLogoutResultCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnLogoutResultCallback(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<LogoutResultDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 创建会话回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback ConvCreateResultCallBack = OnConvCreateResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnConvCreateResultCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<ConvCreateDelgate>(new IMConvCreateResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    ConvInfo = JsonConvert.DeserializeObject<ConvInfo>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 删除会话回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback ConvDeleteResultCallBack = OnConvDeleteResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnConvDeleteResultCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            ptr.Invoke<ConvDeleteDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
        }
        /// <summary>
        /// 获取最近会话回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback ConvGetConvListResultCallBack = OnConvGetConvListResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnConvGetConvListResultCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<ConvDeleteDelgate>(new IMConvGetConvListResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    ConvInfoList = JsonConvert.DeserializeObject<List<ConvInfo>>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 发送消息回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgSendNewMsgResultCallBack = OnMsgSendNewMsgResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgSendNewMsgResultCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgSendNewMsgDelgate>(new IMMsgResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    IMMessage = JsonConvert.DeserializeObject<TMessage>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 消息上报已读回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgReportReadedResultCallBack = OnMsgReportReadedResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgReportReadedResultCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgReportReadedDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 消息撤回回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgRevokeResultCallBack = OnMsgRevokeResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgRevokeResultCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgRevokeDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 根据消息定位精准查找指定会话的消息。
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgFindByMsgLocatorListResultCallBack = OnMsgFindByMsgLocatorListResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgFindByMsgLocatorListResultCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgFindByMsgLocatorListDelgate>(new IMMsgArrayResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    IMMessage_Array = JsonConvert.DeserializeObject<List<TMessage>>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 导入消息列表到指定会话回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgImportMsgListResultCallBack = OnMsgImportMsgListResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgImportMsgListResultCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgImportMsgListDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 保存自定义消息回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgSaveMsgResultCallBack = OnMsgSaveMsgResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgSaveMsgResultCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgSaveMsgDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 获取指定会话的消息列表回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgGetMsgListResultCallBack = OnMsgGetMsgListResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgGetMsgListResultCallBack(int code,string desc, string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgGetMsgListDelgate>(new IMMsgArrayResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    IMMessage_Array = JsonConvert.DeserializeObject<List<TMessage>>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 删除指定会话的消息。
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgDeleteDelgateResultCallBack = OnMsgDeleteDelgateResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgDeleteDelgateResultCallBack(int code,string desc ,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgDeleteDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }

        /// <summary>
        /// 下载成功与否的回调以及下载进度回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgDownloadElemToPathDelgateResultCallBack = OnMsgDownloadElemToPathDelgateResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgDownloadElemToPathDelgateResultCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgDownloadElemToPathDelgate>(new IMDownloadElemResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    DownloadResult = JsonConvert.DeserializeObject<MsgDownloadElemResult>(jsonResult)
                });
            }
        }

        /// <summary>
        /// 群发消息成功与否的回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback MsgBatchSendDelgateResultCallBack = OnMsgBatchSendDelgateResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnMsgBatchSendDelgateResultCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<MsgBatchSendDelgate>(new IMMsgBatchSendResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    BatchSendResult = JsonConvert.DeserializeObject<List<MsgBatchSendResult>>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 创建群组成功与否的回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupCreateResultCallBack = OnGroupCreateResultCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupCreateResultCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupCreateDelgate>(new IMCreateGroupResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    CreatGroupResult = JsonConvert.DeserializeObject<CreateGroupResult>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 删除（解散）群组回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupDeleteCallBack = OnGroupDeleteCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupDeleteCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupDeleteDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 申请加入群组回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupJoinCallBack = OnGroupJoinCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupJoinCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupJoinDelgate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 退出群组回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupQuitCallBack = OnGroupQuitCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupQuitCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupQuitDelegate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 邀请加入群组回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupInviteMemberCallBack = OnGroupInviteMemberCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupInviteMemberCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupInviteMemberDelegate>(new IMGroupInviteMemberResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    GroupInviteResult = JsonConvert.DeserializeObject<List<GroupInviteMemberResult>>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 删除群组成员。
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupDeleteMemberCallBack = OnGroupDeleteMemberCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupDeleteMemberCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupDeleteMemberDelegate>(new IMGroupDeleteMemberResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    GroupDeleterResult = JsonConvert.DeserializeObject<List<GroupDeleteMemberResult>>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 获取已加入群组列表
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupGetJoinedGroupListCallBack = OnGroupGetJoinedGroupList;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupGetJoinedGroupList(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupGetJoinedGroupListDelegate>(new IMGroupBaseInfoResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    GroupBaseInfoResult = JsonConvert.DeserializeObject<List<GroupBaseInfo>>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 获取群组信息列表回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupGetGroupInfoListCallBack = OnGroupGetGroupInfoListCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupGetGroupInfoListCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupGetGroupInfoListDelegate>(new IMGroupGetGroupInfoListResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    GetGroupInfoResult = JsonConvert.DeserializeObject<List<GetGroupInfoResult>>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 修改群信息回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupModifyGroupInfoCallBack = OnGroupModifyGroupInfoCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupModifyGroupInfoCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupModifyGroupInfoDelegate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 获取群成员信息列表回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupGetMemberInfoListCallBack = OnGroupGetMemberInfoListCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupGetMemberInfoListCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupGetMemberInfoListResultDelegate>(new IMGroupGetMemberInfoListResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    GroupGetMemberInfoListResult = JsonConvert.DeserializeObject<GroupGetMemberInfoListResult>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 修改群成员信息回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupModifyMemberInfoCallBack = OnGroupModifyMemberInfoCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupModifyMemberInfoCallBack(int code,string desc,string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupModifyMemberInfoDelegate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 获取群未决信息列表回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupGetPendencyListCallBack = OnGroupGetPendencyListCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupGetPendencyListCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupGetPendencyListDelegate>(new IMGroupPendencyResult()
                {
                    code = code,
                    desc = desc,
                    json_params = jsonResult,
                    GroupPendencyResult = JsonConvert.DeserializeObject<GroupPendencyResult>(jsonResult)
                });
            }
        }
        /// <summary>
        /// 上报群未决信息已读回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupReportPendencyReadedCallBack = OnGroupReportPendencyReadedCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnGroupReportPendencyReadedCallBack(int code,string desc,string jsonResult,IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupReportPendencyReadedDelegate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }
        /// <summary>
        /// 处理群未决信息回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback GroupHandlePendencyCallBack = OnGroupHandlePendencyCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void  OnGroupHandlePendencyCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                ptr.Invoke<GroupHandlePendencyDelegate>(new IMResult() { code = code, desc = desc, json_params = jsonResult });
            }
        }

        /// <summary>
        /// 获取用户信息回调
        /// </summary>
        private static readonly TIMGlobalDef.TIMCommCallback UserProfileHandleCallBack = OnUserProfileHandleCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMCommCallback))]
        static void OnUserProfileHandleCallBack(int code, string desc, string jsonResult, IntPtr ptr)
        {
            if(ptr!= IntPtr.Zero)
            {
                ptr.Invoke<UserProfileHandleDelegate>(new IMUserProfileResult() { code = code,desc = desc,json_params = jsonResult,
                    UserProfiles = JsonConvert.DeserializeObject<List<UserProfile>>(jsonResult)});
            }
        }
        #endregion

        /// <summary>
        /// 获取SDK版本信息
        /// </summary>
        /// <returns></returns>
        public static string IMGetSDKVersion()
        {
            return TIMClientAPIDef.TIMGetSDKVersion();
        }


        /// <summary>
        /// TIM初始化
        /// </summary>
        /// <param name="sdk_app_id">官网申请的SDKAPPID</param>
        /// <param name="json_sdk_config">IM SDK配置</param>
        /// <returns>返回 TIM_SUCC 表示接口调用成功，其他值表示接口调用失败。每个返回值的定义请参考 TIMResult</returns>
        public static TIMResult IMInit(int sdk_app_id, SdKConfig json_sdk_config =null)
        {
            return  (TIMResult)TIMClientAPIDef.TIMInit((ulong)sdk_app_id, json_sdk_config!=null? JsonConvert.SerializeObject(json_sdk_config):null);
        }

        /// <summary>
        /// TIM卸载
        /// </summary>
        /// <returns></returns>
        public static TIMResult IMUninit()
        {
            return (TIMResult)TIMClientAPIDef.TIMUninit();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user_id">用户的 UserID</param>
        /// <param name="user_sig">用户的 UserSig</param>
        /// <param name="handler">登录成功与否的回调。回调函数定义请参考 TIMCommCallback</param>
        public static TIMResult IMLogin(string user_id,string user_sig, LoginResultDelegate handler = null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMLogin(user_id, user_sig, LoginResultCallBack, ptr);
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <param name="handler"></param>
        public static TIMResult IMLogout(LogoutResultDelgate handler = null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMLogout(LogoutResultCallBack, ptr);
        }

        /// <summary>
        /// 创建会话
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="handler">创建会话的回调</param>
        public static TIMResult IMConvCreate(string conv_id, TIMConvType iMConvType ,ConvCreateDelgate handler = null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMConvCreate(conv_id, iMConvType, ConvCreateResultCallBack, ptr);
        }

        /// <summary>
        /// 删除会话
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="handler">删除会话成功与否的回调</param>
        public static TIMResult IMConvDelete(string conv_id,TIMConvType iMConvType, ConvDeleteDelgate handler =null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMConvDelete(conv_id, iMConvType, ConvDeleteResultCallBack, ptr);
        }

        /// <summary>
        /// 获取最近联系人的会话列表。
        /// </summary>
        /// <param name="handler">获取最近联系人会话列表的回调</param>
        public static TIMResult IMConvGetConvList(ConvGetConvListDelgate handler =null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMConvGetConvList(ConvGetConvListResultCallBack,ptr);
        }
        /// <summary>
        /// 设置指定会话的草稿。
        /// </summary>
        /// <param name="conv_id">会话ID</param>
        /// <param name="iMConvType">会话类型</param>
        /// <param name="handler"></param>
        public static TIMResult IMConvSetDraft(string  conv_id,TIMConvType iMConvType,Draft user_draft)
        {
            return (TIMResult)TIMClientAPIDef.TIMConvSetDraft(conv_id, iMConvType,JsonConvert.SerializeObject(user_draft));
        }

        /// <summary>
        /// 删除指定会话的草稿。
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <returns></returns>
        public static TIMResult IMConvCancelDraft(string conv_id,TIMConvType iMConvType)
        {
            return (TIMResult)TIMClientAPIDef.TIMConvCancelDraft(conv_id, iMConvType);
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型</param>
        /// <param name="msg">消息体 kTIMMsgElemArray kTIMMsgSender kTIMMsgClientTime kTIMMsgServerTime</param>
        /// <param name="handler">消息回调</param>
        public static TIMResult IMMsgSendNewMsg(string conv_id,TIMConvType iMConvType,TMessage msg,MsgSendNewMsgDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgSendNewMsg(conv_id, iMConvType, JsonConvert.SerializeObject(msg), MsgSendNewMsgResultCallBack, ptr);
        }
        /// <summary>
        /// 消息上报已读。
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="msg">可以填NULL空字符串指针或者""空字符串，
        /// 此时以会话当前最新消息的时间戳（如果会话存在最新消息）或当前时间为已读时间戳上报。
        /// 当要指定消息时，则以该指定消息的时间戳为已读时间戳上报，最好用接收新消息获取的消息数组里面的消息 JSON 或者用消息定位符查找到的消息 JSON，避免重复构造消息 JSON。</param>
        /// <param name="handler">上报已读回调</param>
        public static TIMResult IMMsgReportReaded(string conv_id,TIMConvType iMConvType, IMessage msg,MsgReportReadedDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgReportReaded(conv_id, iMConvType, JsonConvert.SerializeObject(msg), MsgReportReadedResultCallBack, ptr);
        }
        /// <summary>
        /// 消息撤回。
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="msg">消息撤回。使用保存的消息 JSON 或者用消息定位符查找到的消息 JSON，避免重复构造消息 JSON。</param>
        /// <param name="handler">消息撤回成功与否的回调。</param>
        public static TIMResult IMMsgRevoke(string conv_id,TIMConvType iMConvType, IMessage msg,MsgRevokeDelgate handler = null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgRevoke(conv_id, iMConvType, JsonConvert.SerializeObject(msg), MsgRevokeResultCallBack, ptr);
        }

        /// <summary>
        /// 根据消息定位精准查找指定会话的消息。
        /// 此接口根据消息定位符精准查找指定会话的消息，该功能一般用于消息撤回时查找指定消息等。
        /// 一个消息定位符对应一条消息。
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="msg_arry">消息定位符数组</param>
        /// <param name="handler">根据消息定位精准查找指定会话的消息成功与否的回调</param>
        public static TIMResult IMMsgFindByMsgLocatorList(string conv_id,TIMConvType iMConvType,List<IMessage> msg_arry, MsgFindByMsgLocatorListDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgFindByMsgLocatorList(conv_id, iMConvType, JsonConvert.SerializeObject(msg_arry), MsgFindByMsgLocatorListResultCallBack, ptr);
        }
        /// <summary>
        /// 导入消息列表到指定会话。
        /// 批量导入消息，可以自己构造消息去导入。也可以将之前要导入的消息数组 JSON 保存，然后导入的时候直接调用接口，避免构造消息数组。
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="msg_arry">	消息数组</param>
        /// <param name="handler">导入消息列表到指定会话成功与否的回调</param>
        public static TIMResult IMMsgImportMsgList(string conv_id,TIMConvType iMConvType, List<IMessage> msg_arry,MsgImportMsgListDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgImportMsgList(conv_id, iMConvType, JsonConvert.SerializeObject(msg_arry), MsgImportMsgListResultCallBack, ptr);
        }
        /// <summary>
        /// 保存自定义消息
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="msg">消息</param>
        /// <param name="handler">保存自定义消息成功与否的回调</param>
        public static TIMResult IMMsgSaveMsg(string conv_id,TIMConvType iMConvType, IMessage msg,MsgSaveMsgDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgSaveMsg(conv_id, iMConvType, JsonConvert.SerializeObject(msg), MsgSaveMsgResultCallBack, ptr);
        }
        /// <summary>
        /// 获取指定会话的消息列表
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="msg">消息获取参数</param>
        /// <param name="handler">获取指定会话的消息列表成功与否的回调</param>
        public static TIMResult IMMsgGetMsgList(string conv_id,TIMConvType iMConvType, MsgGetMsgListParam msg,MsgGetMsgListDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgGetMsgList(conv_id, iMConvType, JsonConvert.SerializeObject(msg), MsgGetMsgListResultCallBack, ptr);
        }
        /// <summary>
        /// 删除指定会话的消息。
        /// 当设置kTIMMsgDeleteParamMsg时，在会话中删除指定本地消息。
        /// 当未设置kTIMMsgDeleteParamMsg时，kTIMMsgDeleteParamIsRamble为 false 表示删除会话所有本地消息，true 表示删除会话所有漫游消息（删除漫游消息暂时不支持）。
        /// 一般直接使用保存的消息 JSON，或者通过消息定位符查找得到的 JSON。不用删除的时候构造消息 JSON。
        /// </summary>
        /// <param name="conv_id">会话的 ID</param>
        /// <param name="iMConvType">会话类型，请参考 TIMConvType</param>
        /// <param name="msg">消息获取参数</param>
        /// <param name="handler">删除指定会话的消息成功与否的回调</param>
        public static TIMResult IMMsgDelete(string conv_id,TIMConvType iMConvType, MsgDeleteParam msg,MsgDeleteDelgate handler =null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgDelete(conv_id, iMConvType, JsonConvert.SerializeObject(msg), MsgDeleteDelgateResultCallBack, ptr);
        }
        /// <summary>
        /// 下载消息内元素到指定文件路径（图片、视频、音频、文件）。
        /// </summary>
        /// <param name="downloadElemParam">下载的参数</param>
        /// <param name="savePath">下载文件保存路径</param>
        /// <param name="handler">下载成功与否的回调以及下载进度回调</param>
        public static TIMResult IMMsgDownloadElemToPath(DownloadElemParam downloadElemParam,string savePath, MsgDownloadElemToPathDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgDownloadElemToPath(JsonConvert.SerializeObject(downloadElemParam), savePath, MsgDownloadElemToPathDelgateResultCallBack, ptr);
        }
        /// <summary>
        /// 群发消息
        /// </summary>
        /// <param name="msg">群发消息</param>
        /// <param name="handler">群发消息成功与否的回调</param>
        public static TIMResult IMTIMMsgBatchSend(MsgBatchSendParam msg,MsgBatchSendDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMMsgBatchSend(JsonConvert.SerializeObject(msg), MsgBatchSendDelgateResultCallBack, ptr);
        }
        /// <summary>
        /// 创建群组
        /// </summary>
        /// <param name="createGroupParam">创建群组的参数</param>
        /// <param name="handler">创建群组成功与否的回调</param>
        public static TIMResult IMGroupCreate(CreateGroupParam createGroupParam,GroupCreateDelgate handler = null )
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupCreate(JsonConvert.SerializeObject(createGroupParam), GroupCreateResultCallBack, ptr);
        }
        /// <summary>
        /// 删除（解散）群组
        /// 对于私有群，任何人都无法解散群组
        /// 对于公开群、聊天室和直播大群，群主可以解散群组。
        /// 删除指定群组 group_id 的接口，删除成功与否可根据回调 cb 的参数判断。
        /// </summary>
        /// <param name="group_id">要删除的群组 ID</param>
        /// <param name="handler">删除群组成功与否的回调</param>
        public static TIMResult IMGroupDelete(string group_id,GroupDeleteDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupDelete(group_id, GroupDeleteCallBack, ptr);
        }
        /// <summary>
        /// 申请加入群组。
        /// 私有群不能由用户主动申请入群。
        /// 公开群和聊天室可以主动申请进入。
        /// 如果群组设置为需要审核，申请后管理员和群主会受到申请入群系统消息，
        /// 需要等待管理员或者群主审核，如果群主设置为任何人可加入，则直接入群成功。直播大群可以任意加入群组。
        /// 申请加入指定群组 group_id 的接口，申请加入的操作成功与否可根据回调 cb 的参数判断
        /// </summary>
        /// <param name="group_id">要加入的群组 ID</param>
        /// <param name="hello_msg">申请理由（选填</param>
        /// <param name="handler">申请加入群组成功与否的回调</param>
        public static TIMResult IMGroupJoin(string group_id,string hello_msg,GroupJoinDelgate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return  (TIMResult)TIMClientAPIDef.TIMGroupJoin(group_id, hello_msg, GroupJoinCallBack, ptr);
        }
        /// <summary>
        /// 退出群组
        /// 对于私有群，全员可退出群组。
        /// 对于公开群、聊天室和直播大群，群主不能退出。
        /// 退出指定群组 group_id 的接口
        /// </summary>
        /// <param name="group_id">要退出的群组 ID</param>
        /// <param name="handler">退出群组成功与否的回调</param>
        public static TIMResult IMGroupQuit(string group_id,GroupQuitDelegate handler =null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupQuit(group_id, GroupQuitCallBack, ptr);
        }
        /// <summary>
        /// 邀请加入群组
        /// 只有私有群可以拉用户入群。
        /// 公开群、聊天室邀请用户入群
        /// 需要用户同意；直播大群不能邀请用户入群
        /// </summary>
        /// <param name="groupInviteMember">邀请加入群组参数</param>
        /// <param name="handler">邀请加入群组成功与否的回调</param>
        public static TIMResult IMGroupInviteMember(GroupInviteMemberParam groupInviteMemberParam, GroupInviteMemberDelegate handler =null )
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupInviteMember(JsonConvert.SerializeObject(groupInviteMemberParam), GroupInviteMemberCallBack, ptr);
        }
        /// <summary>
        /// 删除群组成员
        /// 对于私有群：只有创建者可删除群组成员。
        /// 对于公开群和聊天室：只有管理员和群主可以踢人。
        /// 对于直播大群：不能踢人。
        /// </summary>
        /// <param name="groupDeleteMemberParam">删除组员参数</param>
        /// <param name="handler">删除群组成员成功与否的回调</param>
        public static TIMResult IMGroupDeleteMember(GroupDeleteMemberParam groupDeleteMemberParam, GroupDeleteMemberDelegate handler = null )
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupDeleteMember(JsonConvert.SerializeObject(groupDeleteMemberParam), GroupDeleteMemberCallBack, ptr);
        }
        /// <summary>
        /// 获取已加入群组列表。
        /// 此接口可以获取自己所加入的群列表。
        /// 此接口只能获得加入的部分直播大的列表。
        /// 此接口用于获取当前用户已加入的群组列表，返回群组的基础信息。
        /// </summary>
        /// <param name="handler">获取已加入群组列表成功与否的回调</param>
        public static void IMGroupGetJoinedGroupList(GroupGetJoinedGroupListDelegate handler =null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            TIMClientAPIDef.TIMGroupGetJoinedGroupList(GroupGetJoinedGroupListCallBack, ptr);
        }
        /// <summary>
        /// 获取群组信息列表
        /// </summary>
        /// <param name="group_id_arry">获取的群组详情ID集合</param>
        /// <param name="handler">获取群组信息列表成功与否的回调</param>
        public static TIMResult IMGroupGetGroupInfoList(List<string> group_id_arry,GroupGetGroupInfoListDelegate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupGetGroupInfoList(JsonConvert.SerializeObject(group_id_arry), GroupGetGroupInfoListCallBack, ptr);
        }
        /// <summary>
        /// 修改群信息
        /// 修改群主（群转让）的权限说明：
        /// 只有群主才有权限进行群转让操作。
        /// 直播大群不能进行群转让操作。
        /// 修改群其他信息的权限说明：
        /// 对于公开群、聊天室和直播大群，只有群主或者管理员可以修改群简介。
        /// 对于私有群，任何人可修改群简介。
        /// kTIMGroupModifyInfoParamModifyFlag可以按位或设置多个值。不同的 flag 设置不同的键，详情请参考 GroupModifyInfoParam。
        /// </summary>
        /// <param name="groupModifyInfoParam">设置群信息参数</param>
        /// <param name="handler">设置群信息成功与否的回调</param>
        public static TIMResult IMGroupModifyGroupInfo(GroupModifyInfoParam groupModifyInfoParam,GroupModifyGroupInfoDelegate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupModifyGroupInfo(JsonConvert.SerializeObject(groupModifyInfoParam),GroupModifyGroupInfoCallBack , ptr);
        }
        /// <summary>
        /// 获取群成员信息列表。
        /// </summary>
        /// <param name="memberInfo">获取群成员信息列表参数</param>
        /// <param name="handler">获取群成员信息列表成功与否的回调。</param>
        public static TIMResult IMGroupGetMemberInfoList(GroupGetMemberInfoListParam memberInfo,GroupGetMemberInfoListResultDelegate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupGetMemberInfoList(JsonConvert.SerializeObject(memberInfo), GroupGetMemberInfoListCallBack, ptr);
        }
        /// <summary>
        /// 修改群成员信息
        /// 只有群主或者管理员可以进行对群成员的身份进行修改。
        /// 直播大群不支持修改用户群内身份。
        /// 只有群主或者管理员可以进行对群成员进行禁言。
        /// kTIMGroupModifyMemberInfoParamModifyFlag可以按位或设置多个值，不同的 flag 设置不同的键。
        /// </summary>
        /// <param name="groupModifyMemberInfoParam">设置群信息参数</param>
        /// <param name="handler">设置群成员信息成功与否的回调</param>
        public static TIMResult IMGroupModifyMemberInfo(GroupModifyMemberInfoParam groupModifyMemberInfoParam,GroupModifyMemberInfoDelegate handler = null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupModifyMemberInfo(JsonConvert.SerializeObject(groupModifyMemberInfoParam), GroupModifyMemberInfoCallBack,ptr);
        }
        /// <summary>
        /// 获取群未决信息列表群未决信息是指还没有处理的操作，例如，邀请加群或者请求加群操作还没有被处理，称之为群未决信息。
        /// 此处的群未决消息泛指所有需要审批的群相关的操作。例如：加群待审批，拉人入群待审批等等。即便审核通过或者拒绝后，该条信息也可通过此接口拉回，拉回的信息中有已决标志
        /// UserA 申请加入群 GroupA，则群管理员可获取此未决相关信息，UserA 因为没有审批权限，不需要获取此未决信息
        /// 如果 AdminA 拉 UserA 进去 GroupA，则 UserA 可以拉取此未决相关信息，因为该未决信息待 UserA 审批
        /// 权限说明：
        /// 只有审批人有权限拉取相关未决信息。
        /// kTIMGroupPendencyOptionStartTime设置拉取时间戳，第一次请求填0，后边根据 server 返回的 GroupPendencyResult 键kTIMGroupPendencyResultNextStartTime指定的时间戳进行填写。
        /// kTIMGroupPendencyOptionMaxLimited拉取的建议数量，server 可根据需要返回或多或少，不能作为完成与否的标志。
        /// </summary>
        /// <param name="getGroupPendencyParam">设置群未决信息参数</param>
        /// <param name="handler">获取群未决信息列表成功与否的回调</param>
        public static TIMResult IMGroupGetPendencyList(GetGroupPendencyParam getGroupPendencyParam,GroupGetPendencyListDelegate handler = null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupGetPendencyList(JsonConvert.SerializeObject(getGroupPendencyParam), GroupGetPendencyListCallBack, ptr);
        }
        /// <summary>
        /// 上报群未决信息已读
        /// 时间戳 time_stamp 以前的群未决请求都将置为已读。上报已读后，仍然可以拉取到这些未决信息，但可通过对已读时戳的判断判定未决信息是否已读。
        /// </summary>
        /// <param name="time_stamp">已读时间戳（单位秒）。与 GroupPendency 键kTIMGroupPendencyAddTime指定的时间比较</param>
        /// <param name="handler">上报群未决信息已读成功与否的回调</param>
        public static TIMResult IMGroupReportPendencyReaded(ulong time_stamp,GroupReportPendencyReadedDelegate handler = null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupReportPendencyReaded(time_stamp, GroupReportPendencyReadedCallBack, ptr);
        }
        /// <summary>
        /// 处理群未决信息。
        /// 对于群的未决信息，IM SDK 增加了处理接口。审批人可以选择对单条信息进行同意或者拒绝。已处理成功过的未决信息不能再次处理。
        /// 处理未决信息时需要带一个未决信息 GroupPendency，可以在接口 TIMGroupGetPendencyList 返回的未决信息列表将未决信息保存下来，
        /// 在处理未决信息的时候将 GroupPendency 传入键kTIMGroupHandlePendencyParamPendency。
        /// </summary>
        /// <param name="groupPendencyParam">处理群未决信息参数的</param>
        /// <param name="handler">处理群未决信息成功与否的回调</param>
        public static TIMResult IMGroupHandlePendency(GroupPendency groupPendencyParam ,GroupHandlePendencyDelegate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMGroupHandlePendency(JsonConvert.SerializeObject(groupPendencyParam), GroupHandlePendencyCallBack, ptr);
        }

        #region 用户资料相关接口
        /// <summary>
        /// 获取指定用户列表的个人资料
        /// </summary>
        /// <param name="getProfileListParam">用户参数</param>
        /// <param name="handler">获取指定用户列表的用户资料成功与否的回调</param>
        /// <returns></returns>
        public static TIMResult IMProfileGetUserProfileList(GetProfileListParam getProfileListParam, UserProfileHandleDelegate handler=null)
        {
            var ptr = DelegateConverter.ConvertToIntPtr(handler);
            return (TIMResult)TIMClientAPIDef.TIMProfileGetUserProfileList(JsonConvert.SerializeObject(getProfileListParam), UserProfileHandleCallBack, ptr);
        }
        #endregion
    }
}
