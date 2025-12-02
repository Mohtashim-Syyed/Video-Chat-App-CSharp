using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Video_Chat_application
{
    public partial class Form1 : Form
    {
        static IPAddress myip, friendip;
       // static int localport_, remoteport_;
        static int con_type;
        public Form1(IPAddress myip_, IPAddress freindip_, int connectiontype)
        {
            InitializeComponent();
            friendip = freindip_;
            myip = myip_;
            con_type = connectiontype;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            axVideoChatSender1.VideoDevice = (short)(con_type);
            axVideoChatSender1.AudioDevice = 0;
            axVideoChatSender1.VideoFormat = 0;
            axVideoChatSender1.FrameRate = 15;
            axVideoChatSender1.VideoBitrate = 128000;
            axVideoChatSender1.AudioComplexity = 0;
            axVideoChatSender1.AudioQuality = 8;
            axVideoChatSender1.SendAudioStream = true;
            axVideoChatSender1.SendVideoStream = true;

            int a = axVideoChatSender1.Connect(friendip.ToString(), 82);
            MessageBox.Show(a.ToString());


            axVideoChatReceiver1.ReceiveAudioStream = true;

            axVideoChatReceiver1.ReceiveVideoStream = true;
            bool b = axVideoChatReceiver1.Listen(myip.ToString(), 82);
            MessageBox.Show(b.ToString());

        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            axVideoChatReceiver1.Disconnect();
            axVideoChatSender1.Disconnect();
        }
    }
}
