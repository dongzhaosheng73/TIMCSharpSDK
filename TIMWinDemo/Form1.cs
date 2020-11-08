using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TIMSDK.api.Core.Client;
using TIMSDKDemo;

namespace TIMWinDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            int appid = 1400350934;

            string key = "dde469a0a3222fe1868f4157b5ae2562fe874bd0a2408274133c9a3b65e4cca9";

            var data = new { sdk_config_log_file_path = AppDomain.CurrentDomain.BaseDirectory, sdk_config_config_file_path = AppDomain.CurrentDomain.BaseDirectory };

            var user_id = "10005";

            TLSSigAPIv2 api = new TLSSigAPIv2(appid, key);

            Console.WriteLine($"init rest:{TIMClientAPIDef.TIMInit((ulong)appid, JsonConvert.SerializeObject(data))}");

            var status = TIMClientAPIDef.TIMLogin(user_id, api.GenSig(Util.UTF16To8(user_id)), (c,des,json,d)=> 
            {

                MessageBox.Show(c.ToString());

            }, IntPtr.Zero);

            Console.WriteLine($"login status:{status}");

        }
    }
}
