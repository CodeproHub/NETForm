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
    /// <summary>
    /// 说明：将网站页面已txt文件的形式保存到程序所在的文件夹
    /// </summary>
    public partial class webClient : Form
    {
        public webClient()
        {
            InitializeComponent();
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            lblmessage.Text = "";
            try
            {
                WebClient wclient = new WebClient();
                wclient.BaseAddress = txtweb.Text;
                wclient.Encoding = Encoding.UTF8;
                wclient.Headers.Add("Content-type", "application/x-www-form-urlencoded");
                Stream stream = wclient.OpenRead(txtweb.Text);
                StreamReader streamreader = new StreamReader(stream);
                string str = string.Empty;
                while ((str = streamreader.ReadLine()) != null)
                {
                    rtxtshow.Text = str + "\n";
                }
                wclient.DownloadFile(txtweb.Text, DateTime.Now.ToFileTime() + ".txt");
                lblmessage.Text = "保存文件成功";

            }
            catch (Exception ex)
            {
                rtxtshow.Text = ex.ToString();
            }
        }
    }
}
