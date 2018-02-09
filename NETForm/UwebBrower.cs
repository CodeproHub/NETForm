using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETForm
{
    /// <summary>
    /// 说明：简易浏览器，
    /// 缺点：非常吃内存，卡
    /// </summary>
    public partial class UwebBrower : Form
    {
        public UwebBrower()
        {
            InitializeComponent();
        }

        private void btnOPen_Click(object sender, EventArgs e)
        {
            label1.Text = "网址：";
            try
            {
                Uri uri = new Uri(txtweb.Text);
                webBrowser1.Url = uri;
            }
            catch (Exception ex)
            {
                label1.Text = ex.ToString();
            }
        }

        private void txtweb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtweb.Text != "")
                {
                    btnOPen_Click(sender ,e);
                }
            }
        }
    }
}
