using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIMSDK.API.Core.Command;
using TIMSDK.Core.Client;
using TIMSDK.Model;
using TIMUtity;

namespace TIMSDK.API.Core
{
    public class TIMGlobal
    {
        #region Event
        /// <summary>
        /// 最新消息
        /// </summary>
        public static event EventHandler<TIMAddRecvNewMsgArgs> TIMAddRecvNewMsgChangedHandler;
        /// <summary>
        /// 删除接收新消息回调
        /// </summary>
        public static event EventHandler<TIMRemoveRecvNewMsgArgs> TIMRemoveRecvNewMsgChangedHandler;
        /// <summary>
        /// 消息已读回执回调
        /// </summary>
        public static event EventHandler<TIMMsgReadedReceiptcArgs> TIMMsgReadedReceiptChangedHandler;
        /// <summary>
        /// 接收的消息被撤回回调。
        /// </summary>
        public static event EventHandler<TIMMsgRevokeArgs> TIMMsgRevokeChangedHandler;
        /// <summary>
        /// 消息内元素相关文件上传进度回调。
        /// </summary>
        public static event EventHandler<TIMMsgElemUploadProgressArgs> TIMMsgElemUploadProgressChangedHandler;
        /// <summary>
        /// 群事件回调。
        /// </summary>
        public static event EventHandler<TIMGroupTipsEventArgs> TIMGroupTipsEventHandler;
        /// <summary>
        /// 会话事件回调
        /// </summary>
        public static event EventHandler<TIMConvEventArgs> TIMConvEventHandler;
        /// <summary>
        /// 网络状态回调
        /// </summary>
        public static event EventHandler<TIMNetworkStatusListenerArgs> TIMNetworkStatusListenerChangedHandler;
        /// <summary>
        /// 被踢下线回调
        /// </summary>
        public static event EventHandler<TIMKickedOfflineArgs> TIMKickedOfflineHandler;
        /// <summary>
        /// 用户票据过期回调。
        /// </summary>
        public static event EventHandler<TIMUserSigExpiredArgs> TIMUserSigExpiredHandler;
        /// <summary>
        /// 日志回调。
        /// </summary>
        public static event EventHandler<TIMLogArgs> TIMLogHandler;
        /// <summary>
        /// 消息更新回调。
        /// </summary>
        public static event EventHandler<TIMMsgUpdateArgs> TIMMsgUpdateHandler;

        #endregion

        #region CallBack

        private static readonly TIMGlobalDef.TIMAddRecvNewMsgCallback AddRecvNewMsgCallback = OnAddRecvNewMsgCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMAddRecvNewMsgCallback))]
        static void OnAddRecvNewMsgCallback(string json_msg_array, IntPtr ptr)
        {
            List<TMessage> msglist = null;
            if (TIMAddRecvNewMsgChangedHandler!=null)
            {
                if(!string.IsNullOrWhiteSpace(json_msg_array))
                {
                    msglist = JsonConvert.DeserializeObject<List<TMessage>>(json_msg_array);
                }
                TIMAddRecvNewMsgChangedHandler.Invoke(null, new TIMAddRecvNewMsgArgs(msglist));
            }
        }

        private static readonly TIMGlobalDef.TIMRemoveRecvNewMsgCallback RemoveRecvNewMsgCallback = OnRemoveRecvNewMsgCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMRemoveRecvNewMsgCallback))]
        static void OnRemoveRecvNewMsgCallback(string json_msg_array, IntPtr ptr)
        {
            List<TMessage> msglist = null;
            if (TIMRemoveRecvNewMsgChangedHandler != null)
            {
                if (!string.IsNullOrWhiteSpace(json_msg_array))
                {
                    msglist = JsonConvert.DeserializeObject<List<TMessage>>(json_msg_array);
                }
                TIMRemoveRecvNewMsgChangedHandler.Invoke(null, new TIMRemoveRecvNewMsgArgs(msglist));
            }
        }

        private static readonly TIMGlobalDef.TIMMsgReadedReceiptCallback MsgReadedReceiptCallback = OnMsgReadedReceiptCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMMsgReadedReceiptCallback))]
        static void OnMsgReadedReceiptCallback(string json_msg_arry,IntPtr ptr)
        {
            MessageReceipt messageReceipt = null;
            if(TIMRemoveRecvNewMsgChangedHandler!=null)
            {
                if(!string.IsNullOrWhiteSpace(json_msg_arry))
                {
                    messageReceipt = JsonConvert.DeserializeObject<MessageReceipt>(json_msg_arry);
                }
                TIMMsgReadedReceiptChangedHandler.Invoke(null, new TIMMsgReadedReceiptcArgs(messageReceipt));
            }
        }

        private static readonly TIMGlobalDef.TIMMsgRevokeCallback MsgRevokCallBack = OnMsgRevokCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMMsgRevokeCallback))]
        static void OnMsgRevokCallBack(string json_msg_arry, IntPtr ptr)
        {
            MsgLocator msgLocator = null;
            if (TIMMsgRevokeChangedHandler != null)
            {
                if (!string.IsNullOrWhiteSpace(json_msg_arry))
                {
                    msgLocator = JsonConvert.DeserializeObject<MsgLocator>(json_msg_arry);
                }
                TIMMsgRevokeChangedHandler.Invoke(null, new TIMMsgRevokeArgs(msgLocator));
            }
        }

        private static readonly TIMGlobalDef.TIMMsgElemUploadProgressCallback MsgElemUploadProgressCallback = OnMsgElemUploadProgressCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMMsgElemUploadProgressCallback))]
        static void OnMsgElemUploadProgressCallback(string json_msg_arry,int index,int cur_size,int total_size,IntPtr user_data)
        {
            List<TMessage> messages = null;
            if(TIMMsgElemUploadProgressChangedHandler!=null)
            {
                if(!string.IsNullOrWhiteSpace(json_msg_arry))
                {
                    messages = JsonConvert.DeserializeObject<List<TMessage>>(json_msg_arry);
                }
                TIMMsgElemUploadProgressChangedHandler.Invoke(null, new TIMMsgElemUploadProgressArgs(messages, index, cur_size, total_size));
            }
        }

        private static readonly TIMGlobalDef.TIMGroupTipsEventCallback GroupTipsEventCallback = OnGroupTipsEventCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMGroupTipsEventCallback))]
        static void OnGroupTipsEventCallback(string json_msg_arry,IntPtr user_data)
        {
            GroupTipsElem tips = new GroupTipsElem();
            if(TIMGroupTipsEventHandler!=null)
            {
                if(!string.IsNullOrWhiteSpace(json_msg_arry))
                {
                    try
                    {
                        tips  = JsonConvert.DeserializeObject<GroupTipsElem>(json_msg_arry);
                    }
                    catch(Exception ex)
                    {

                    }
                    
                }
                TIMGroupTipsEventHandler.Invoke(null, new TIMGroupTipsEventArgs(tips));
            }
        }

        private static readonly TIMGlobalDef.TIMConvEventCallback ConvEventCallback = OnTIMConvEventCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMConvEventCallback))]
        static void OnTIMConvEventCallback(TIMConvEvent conv_event,string json_msg_arry,IntPtr ptr)
        {
            List<ConvInfo> convs = null;
            if(TIMConvEventHandler!=null)
            {
                if(!string.IsNullOrWhiteSpace(json_msg_arry))
                {
                    convs = JsonConvert.DeserializeObject<List<ConvInfo>>(json_msg_arry);
                }
                TIMConvEventHandler.Invoke(null, new TIMConvEventArgs(conv_event, convs));
            }

        }

        private static readonly TIMGlobalDef.TIMKickedOfflineCallback KickedOfflineCallback = OnKickedOfflineCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMKickedOfflineCallback))]
        static void OnKickedOfflineCallback(IntPtr ptr)
        {
            if(TIMKickedOfflineHandler!=null)
            {
                TIMKickedOfflineHandler.Invoke(null, new TIMKickedOfflineArgs());
            }
        }

        private static readonly TIMGlobalDef.TIMNetworkStatusListenerCallback NetworkStatusListenerCallback = OnNetworkStatusListenerCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMNetworkStatusListenerCallback))]
        static void OnNetworkStatusListenerCallback(TIMNetworkStatus status,int code,string desc,IntPtr ptr)
        {
            if(TIMNetworkStatusListenerChangedHandler!=null)
            {
                TIMNetworkStatusListenerChangedHandler.Invoke(null, new TIMNetworkStatusListenerArgs(status, code, desc));
            }
        }

        private static readonly TIMGlobalDef.TIMUserSigExpiredCallback UserSigExpiredCallback = OnUserSigExpiredCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMUserSigExpiredCallback))]
        static void OnUserSigExpiredCallback(IntPtr ptr)
        {
            if(TIMUserSigExpiredHandler!=null)
            {
                TIMUserSigExpiredHandler.Invoke(null, new TIMUserSigExpiredArgs());
            }
        }

        private static readonly TIMGlobalDef.TIMLogCallback LogCallBack = OnLogCallBack;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMLogCallback))]
        static void OnLogCallBack(TIMLogLevel level,string log,IntPtr ptr)
        {
            if(TIMLogHandler!=null)
            {
                TIMLogHandler.Invoke(null, new TIMLogArgs(level, log));
            }
        }

        private static readonly TIMGlobalDef.TIMMsgUpdateCallback MsgUpdateCallback = OnMsgUpdateCallback;
        [MonoPInvokeCallback(typeof(TIMGlobalDef.TIMMsgUpdateCallback))]
        static void OnMsgUpdateCallback(string json_msg_array,IntPtr ptr)
        {
            List<string> msgs = null;
            if(TIMMsgUpdateHandler!=null)
            {
                if(!string.IsNullOrWhiteSpace(json_msg_array))
                {
                    msgs = JsonConvert.DeserializeObject<List<string>>(json_msg_array);
                }
                TIMMsgUpdateHandler.Invoke(null, new TIMMsgUpdateArgs(msgs));
            }
        }
        #endregion

        public static void RegisterTIMCallBack()
        {
            TIMClientAPIDef.TIMSetLogCallback(LogCallBack, IntPtr.Zero);

            TIMClientAPIDef.TIMAddRecvNewMsgCallback(AddRecvNewMsgCallback,IntPtr.Zero);

            TIMClientAPIDef.TIMRemoveRecvNewMsgCallback(RemoveRecvNewMsgCallback, IntPtr.Zero);

            TIMClientAPIDef.TIMSetMsgReadedReceiptCallback(MsgReadedReceiptCallback, IntPtr.Zero);

            TIMClientAPIDef.TIMSetMsgRevokeCallback(MsgRevokCallBack, IntPtr.Zero);

            TIMClientAPIDef.TIMSetMsgElemUploadProgressCallback(MsgElemUploadProgressCallback, IntPtr.Zero);

            TIMClientAPIDef.TIMSetGroupTipsEventCallback(GroupTipsEventCallback, IntPtr.Zero);

            TIMClientAPIDef.TIMSetConvEventCallback(ConvEventCallback, IntPtr.Zero);

            TIMClientAPIDef.TIMSetNetworkStatusListenerCallback(NetworkStatusListenerCallback, IntPtr.Zero);

            TIMClientAPIDef.TIMSetKickedOfflineCallback(KickedOfflineCallback, IntPtr.Zero);

            TIMClientAPIDef.TIMSetUserSigExpiredCallback(UserSigExpiredCallback, IntPtr.Zero);

            TIMClientAPIDef.TIMSetMsgUpdateCallback(MsgUpdateCallback, IntPtr.Zero);
        }
    }
}
