using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chatS;


namespace chatC
{
    public partial class Form1 : Form
    {
        chatServer chatServ = new chatServer();
        System.Diagnostics.Process myProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myProcess = System.Diagnostics.Process.Start("chatS.exe");
            
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            lblmess.Text = chatServer.Send(txtIp.Text, txtmess.Text);
            txtmess.Text = "";
            txtmess.Focus();
        }

        private void txtIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnsend.Focus();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myProcess.Kill();
        }
    }
}
