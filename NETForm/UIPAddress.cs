using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETForm
{
    public partial class UIPAddress : Form
    {
        public UIPAddress()
        {
            InitializeComponent();
        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            

            if (txtweb.Text == string.Empty)
            {
                lblmessage.Text = "请输入网站";
            }
            else
            {
                try
                {
                    IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(txtweb.Text), 80);
                    lblmessage.Text = "IP地址：" + iPEndPoint.Address.ToString() + "\n 端口号：" + iPEndPoint.Port;

                    //IPAddress[] ips = Dns.GetHostAddresses(txtweb.Text);
                    //foreach (IPAddress ip in ips)
                    //{
                    //    lblmessage.Text = "网络协议地址" + ip.Address + "\n IP地址的地址族" + ip.AddressFamily.ToString() + "\n 是否为IPV6 " + ip.IsIPv6LinkLocal;
                    //}
                }
                catch (Exception ex)
                {
                    lblmessage.Text = ex.ToString();
                }


            }
        }
    }
}
