using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatS
{
   public class chatServer
    {
        public const int port = 11000;
        public static void StartListener()
        {
            UdpClient udpClient = new UdpClient(port);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any,port);
            try
            {
                while (true)
                {
                    byte[] bytes = udpClient.Receive(ref iPEndPoint);
                    string strIP = "信息来自：" + iPEndPoint.Address.ToString();
                    string strInfo = Encoding.GetEncoding("gb2312").GetString(bytes,0,bytes.Length);
                    MessageBox.Show(strInfo, strIP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                udpClient.Close();
            }
        }

        public static string Send(string strServer,string strContent)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            IPAddress iPAddress = IPAddress.Parse(strServer);
            byte[] btContent = Encoding.GetEncoding("gb2312").GetBytes(strContent);
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
            socket.SendTo(btContent,iPEndPoint);
            socket.Close();
            return "发生成功";
        }
    }
}
