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
using System.Net.Sockets;

namespace Video_Chat_application
{
    public partial class mainform : Form
    {
        static IPAddress myip;
        static IPAddress friendip;
        static int localport_, remoteport_;
        
        public mainform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(myip, friendip, 0);
            f.ShowDialog();

        }

        private void chatting_Click(object sender, EventArgs e)
        {
            chat_form cf = new chat_form(myip,friendip,localport_,remoteport_);
            cf.ShowDialog();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                myip = IPAddress.Parse(textBox1.Text);
                friendip = IPAddress.Parse(textBox2.Text);
                localport_ = Convert.ToInt16(localport.Text);
                remoteport_ = Convert.ToInt16(remoteport.Text);

                MessageBox.Show("connection established");
                button1.Enabled = true;
                video_calling.Enabled = true;
                chatting.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid IP address and Port No.!!");
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1(myip, friendip, 1);
            f.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //this method gets the local ip address of the device using dns hostentry.
        private string getLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        //getlocalips ends here.

        private void mainform_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            chatting.Enabled = false;
            video_calling.Enabled = false;
            textBox1.Text = getLocalIP();
        }
    }
}
