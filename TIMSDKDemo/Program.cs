using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TIMSDK;
using TIMSDK.Core.Client;

namespace TIMSDKDemo
{
    public class Program
    {
        /// <summary>
        /// TIM 消息机制必须依赖于独立APP 因此控制台无法从SDK中接收消息
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main(string[] args)
        {
            int appid = 1400350934;

            string key = "key";

            string user_id = "user_id";

            Console.WriteLine($"init api status:{TIMClient.IMInit(appid, new TIMSDK.Model.SdKConfig() { kTIMSdkConfigConfigFilePath = AppDomain.CurrentDomain.BaseDirectory, kTIMSdkConfigLogFilePath = AppDomain.CurrentDomain.BaseDirectory })}");

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            System.Windows.Forms.Form win = new System.Windows.Forms.Form();

            win.Load += (o, s) =>
            {
                Console.WriteLine("Thread Start");

                TLSSigAPIv2 api = new TLSSigAPIv2(appid, key);

                TIMClient.IMLogin(user_id, api.GenSig(Util.UTF16To8(user_id)), (rest) =>
                {
                    Console.WriteLine($"login: code:{rest.code} desc:{rest.desc}");
                });
            };


            Application.Run(win);

            Console.ReadKey();

            TIMClient.IMLogout();

            TIMClient.IMUninit();
        }


    }
}
