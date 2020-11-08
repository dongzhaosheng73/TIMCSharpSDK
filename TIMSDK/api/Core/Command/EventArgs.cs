using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TIMSDK.Model;

namespace TIMSDK.API.Core.Command
{
    public class TIMAddRecvNewMsgArgs : EventArgs
    {
        public TIMAddRecvNewMsgArgs(List<TMessage> msgs)
        {
            MsgArray = msgs;
        }

        public List<TMessage> MsgArray { private set; get; }
    }
    public class TIMRemoveRecvNewMsgArgs : EventArgs
    {
        public TIMRemoveRecvNewMsgArgs(List<TMessage> msgs)
        {
            MsgArray = msgs;
        }

        public List<TMessage> MsgArray { private set; get; }
    }

    public class TIMMsgReadedReceiptcArgs:EventArgs
    {
        public TIMMsgReadedReceiptcArgs(MessageReceipt receipt)
        {
            MessageReceipt = receipt;
        }

        public MessageReceipt MessageReceipt { private set; get; }
    }

    public class TIMMsgRevokeArgs:EventArgs
    {
        public TIMMsgRevokeArgs(MsgLocator msgLocator)
        {
            RevokeMsg = msgLocator;
        }

        public MsgLocator RevokeMsg { private set; get; }
    }

    public class TIMMsgElemUploadProgressArgs:EventArgs
    {
        public TIMMsgElemUploadProgressArgs(List<TMessage> msgs,int index,int cur_size,int total_size)
        {
            Megs = msgs;
            Index = index;
            Cur_Size = Cur_Size;
            Total_Size = total_size;
        }

        public List<TMessage> Megs { private set; get; }

        public int Index { private set; get; }

        public int Cur_Size { private set; get; }
       
        public int Total_Size { private set; get; }
    }

    public class TIMGroupTipsEventArgs:EventArgs
    {
        public TIMGroupTipsEventArgs(GroupTipsElem group_tip)
        {
            Group_Tip = group_tip;
        }

        public GroupTipsElem Group_Tip { private set; get; }
    }

    public class TIMConvEventArgs:EventArgs
    {
        public TIMConvEventArgs(TIMConvEvent conv_event,List<ConvInfo> conv_arry)
        {
            Conv_Event = conv_event;
            Conv_Arry = conv_arry;
        }

        public TIMConvEvent Conv_Event { private set; get; }

        public List<ConvInfo> Conv_Arry { private set; get; }
    }

    public class TIMNetworkStatusListenerArgs:EventArgs
    {
        public TIMNetworkStatusListenerArgs(TIMNetworkStatus status,int code,string desc)
        {
            NetworkStatus = status;
            Code = code;
            Desc = desc;
        }

        public TIMNetworkStatus NetworkStatus { private set; get; }

        public int Code { private set; get; }

        public string Desc { private set; get; }
    }

    public class TIMKickedOfflineArgs:EventArgs
    {
        public TIMKickedOfflineArgs()
        {

        }
    }

    public class TIMUserSigExpiredArgs : EventArgs
    {
        public TIMUserSigExpiredArgs()
        {

        }
    }

    public class TIMLogArgs:EventArgs
    {
        public TIMLogArgs(TIMLogLevel logLevel,string log)
        {
            LogLevel = logLevel;
            Log = log;
        }

        public TIMLogLevel LogLevel { private set; get; }

        public string Log { private set; get; }
    }

    public class TIMMsgUpdateArgs:EventArgs
    {
        public TIMMsgUpdateArgs(List<string> msgs)
        {
            Msgs = msgs;
        }

        public List<string> Msgs { private set; get; }
    }
}
