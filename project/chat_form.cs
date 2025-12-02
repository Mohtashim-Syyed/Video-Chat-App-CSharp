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
    public partial class chat_form : Form
    {

        static IPAddress localip, remoteip;
        static int localport, remoteport;
        Socket sck;
        EndPoint localEp, remoteEp;
        byte[] buffer;
        public chat_form(IPAddress localip_, IPAddress remoteip_, int localport_, int remoteport_)
        {
        //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            string sh=setConnection();
            MessageBox.Show(sh);
}

        private void chat_form_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            string sh=setConnection();
            MessageBox.Show(sh);

        }

        


        private string setConnection()
        {
            //initializing endpoints.
            localEp = new IPEndPoint(localip, localport);
            remoteEp = new IPEndPoint(remoteip, remoteport);
            //binding endpoints to socket
            sck.Bind(localEp);
            sck.Bind(remoteEp);
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEp, new AsyncCallback(MessageCallBack), buffer);
            return "connection established";

        }

        //messagecallback method.
        private void MessageCallBack(IAsyncResult aresult)
        {
            
                byte[] msg = new byte[1500];
                msg = (byte[])aresult.AsyncState;
                //printing message on listbox
                string rec_msg = Encoding.ASCII.GetString(msg);
                listMessages.Items.Add("Friend: " + rec_msg);

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteEp, new AsyncCallback(MessageCallBack), buffer);
            
            
        }
        //messagecallback ends here.

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] send_msg = new byte[1500];
            send_msg = Encoding.ASCII.GetBytes(textBox1.Text);
            sck.Send(send_msg);
            listMessages.Items.Add("Me: " + textBox1.Text);
            textBox1.Text = "";

        }
        
    }
}
