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
    public partial class DNSQuary : Form
    {
        public DNSQuary()
        {
            InitializeComponent();
        }

        private void btnqurey_Click(object sender, EventArgs e)
        {
            if (txtweb.Text == string.Empty)
            {
                lblmessage.Text = "请输入需要查询的网站";
            }
            else
            {
                IPAddress[] ips = Dns.GetHostAddresses(txtweb.Text);
                foreach (IPAddress ip in ips)
                {
                    txtip.Text = ip.ToString();
                }
                txtloca.Text = Dns.GetHostName();
                txtnds.Text = Dns.GetHostByName(Dns.GetHostName()).HostName;
            }
        }
    }
}
