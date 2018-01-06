using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace RF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        System.Timers.Timer t = new System.Timers.Timer(10000);
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint iped = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 10000);
        byte[] receiveBytes=new byte[1024];
        //实例化一个远程端点，IP和端口可以随意指定，等调用client.Receive(ref remotePoint)时会将该端点改成真正发送端端点 
　　    IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);
        //Init new socket*******************************************初始化新的套接字
        TcpClient tcpClient = new TcpClient();  
        //Starte asynchronen Connect********************************启动asynchronen连接
        connectResult = tcpClient.BeginConnect(TextBox_TelnetServerIP.Text, CInt(TextBox_TelnetSocketNb.Text),Nothing, Nothing);

      Bitmap Range_Pic = new Bitmap(256, 256);
      Bitmap Doppler_Pic = new Bitmap(256, 256);

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void Button_TelnetConnect_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
             try
            {
            // Warte auf Bytes
          //  receiveBytes = receivingUdpClient.Receive(remoteIpEndPoint);
            }
             catch (Exception ex)
            {
           
            }
       
        }

        private void chart_ADC_Click(object sender, EventArgs e)
        {

        }
    }
}
