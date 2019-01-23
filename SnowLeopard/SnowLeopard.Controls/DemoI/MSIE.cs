using Newtonsoft.Json;
using SnowLeopard.Controls.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowLeopard.Controls.DemoI
{
    public partial class MSIE : SnowLeopard.Controls.BlueForm
    {
        public MSIE()
        {
            InitializeComponent();
        }

        private async void MSIE_Load(object sender, EventArgs e)
        {
            //var client = new HttpClient();
            //client.BaseAddress = new Uri("https://cloud.roadefend.com/");
            ////client.DefaultRequestHeaders.Add("username", "zhuser");
            ////client.DefaultRequestHeaders.Add("password", "961bd6e205c7accf70be384161a3aae2b8bb2104e93642393e578369172b13ef47461a67f4a95770f58f7ab88dc3111c6a199a001ae29a5c53208681b4158c1c");
            //var response = await client.GetAsync("loginRDFEmbedded.action?username=zhuserx&password=961bd6e205c7accf70be384161a3aae2b8bb2104e93642393e578369172b13ef47461a67f4a95770f58f7ab88dc3111c6a199a001ae29a5c53208681b4158c1c");
            //var responseStr = await response.Content.ReadAsStringAsync();
            //var result = JsonConvert.DeserializeObject<LoginResult>(responseStr);
            //MessageBox.Show($"IsSuccess: {result.success}");

            //var sTest = "http://liulanmi.com/labs/core.html";
            var authUrl = "https://cloud.roadefend.com/loginRDFEmbedded.action?username=zhuser&password=961bd6e205c7accf70be384161a3aae2b8bb2104e93642393e578369172b13ef47461a67f4a95770f58f7ab88dc3111c6a199a001ae29a5c53208681b4158c1c";
            var pageUrl = "https://cloud.roadefend.com/";
            var result = await HttpGet(authUrl);
            var loginResult = JsonConvert.DeserializeObject<LoginResult>(result);
            var sIsSuccess = loginResult.success ? "成功" : "失败";
            //MessageBox.Show($"登陆{sIsSuccess}");
            webBrowser1.Url = new Uri(pageUrl);

            //webBrowser1.Url = new Uri(sAuth);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public static async Task<string> HttpGet(string sUrl)
        {
            try
            {
                var request = HttpWebRequest.Create(sUrl);
                var response = await request.GetResponseAsync();
                using (var stream = response.GetResponseStream())
                using (var sr = new StreamReader(stream))
                {
                    return await sr.ReadToEndAsync();
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
