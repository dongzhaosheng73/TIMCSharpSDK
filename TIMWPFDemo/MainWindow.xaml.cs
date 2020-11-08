using GalaSoft.MvvmLight.Threading;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using TIMSDK;
using TIMSDK.API.Core;
using TIMSDK.API.Core.Command;
using TIMSDK.Core.Client;
using TIMSDKDemo;

namespace TIMWPFDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        int appid = 1400352829;

        string key = "key";

        string user_id = "user_id";

        private ObservableCollection<string> _LogMessage = new ObservableCollection<string>();
        public ObservableCollection<string> LogMessage
        {
            set { if (value != _LogMessage) { _LogMessage = value;NotifyPropertyChanged("LogMessage"); } }
            get => _LogMessage;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public MainWindow()
        {
            JsonDemo jso = new JsonDemo();

            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.Closed += MainWindow_Closed;
        }



        private void MainWindow_Closed(object sender, EventArgs e)
        {
            TIMClient.IMUninit();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        
        private void OnTIMLogCallBack(TIMLogLevel level,string log,IntPtr data)
        {
            LogMessageSet($"logleve:{level} log:{log}");
        }

       // private TIMSetNetworkStatusListenerCallback networkstatus_callback;

        private void OnTIMNetworkStatusCallBack(TIMNetworkStatus status,int code,string desc,IntPtr data)
        {
            LogMessageSet($"network status:{status} code:{code} desc:{desc}");
        }

        private void Init()
        {
            var data = new { sdk_config_log_file_path = AppDomain.CurrentDomain.BaseDirectory, sdk_config_config_file_path = AppDomain.CurrentDomain.BaseDirectory };

            TLSSigAPIv2 api = new TLSSigAPIv2(appid, key);

            LogMessageSet($"init api status:{TIMClient.IMInit(appid,new TIMSDK.Model.SdKConfig(){ kTIMSdkConfigConfigFilePath = AppDomain.CurrentDomain.BaseDirectory, kTIMSdkConfigLogFilePath = AppDomain.CurrentDomain.BaseDirectory })}");

            TIMGlobal.RegisterTIMCallBack();

            TIMGlobal.TIMLogHandler += OnLog;

            TIMGlobal.TIMNetworkStatusListenerChangedHandler += OnNetworkStatusListenerChanged;

            TIMGlobal.TIMUserSigExpiredHandler += TIMGlobal_TIMUserSigExpiredHandler;


            //log_callback = new TIMLogCallback(OnTIMLogCallBack);

            //TIMClientAPITIMSetLogCallback(log_callback, IntPtr.Zero);

            //networkstatus_callback = new TIMSetNetworkStatusListenerCallback(OnTIMNetworkStatusCallBack);

            //TIMClientAPIDef.TIMSetNetworkStatusListenerCallback(networkstatus_callback, IntPtr.Zero);
        }

        private void TIMGlobal_TIMUserSigExpiredHandler(object sender, TIMUserSigExpiredArgs e)
        {
            
        }

        private void OnNetworkStatusListenerChanged(object sender,TIMNetworkStatusListenerArgs arg)
        {
            LogMessageSet($"network status:{arg.NetworkStatus} code:{arg.Code} desc:{arg.Desc}");
        }

        private void OnLog(object sender, TIMLogArgs arg )
        {
            LogMessageSet($"logleve:{arg.LogLevel} log:{arg.Log}");
        }

        private void LogMessageSet(string msg)
        {
             LogMessage.Add(msg);         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TLSSigAPIv2 api = new TLSSigAPIv2(appid, key);

            var sing = api.GenSig(Util.UTF16To8(user_id));

            TIMClient.IMLogin(user_id, sing, (rest) =>
            {
                LogMessageSet($"login: code {rest.code} des{rest.desc}");
            });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TIMClient.IMLogout((rest) => 
            {
                LogMessageSet($"logout: code {rest.code} des{rest.desc}");
            });

        }
    }
}
