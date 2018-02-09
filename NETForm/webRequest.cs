using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETForm
{
    public partial class webRequest : Form
    {
        public webRequest()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(txtweb.Text);
                webRequest.Credentials = CredentialCache.DefaultCredentials;
                rtxtshow.Text = "请求数据的内容长度：" + webRequest.ContentLength
                                + "\n请求的协议方法：" + webRequest.Method
                                + "\n访问Internet的网络代理" + webRequest.Proxy
                                + "\n与请求关联的Internet URL" + webRequest.RequestUri
                                + "\n超时时间" + webRequest.Timeout;
                WebResponse webRe = webRequest.GetResponse();
                rtxtshow.Text += "\n响应该请求的URL" + webRe.ResponseUri;
                Stream stream = webRe.GetResponseStream();
                StreamReader streamr = new StreamReader(stream);
                rtxtshow.Text += "\n" + streamr.ReadToEnd();
                streamr.Close();
                stream.Close();
                webRe.Close();
            }
            catch (Exception ex)
            {
                rtxtshow.Text = ex.ToString();
            }
        }
    }
}
