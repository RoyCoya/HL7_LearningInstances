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
using System.Threading;
using Client;

namespace HL7
{
    public partial class clientWindow : Form
    {
        Client.Client clientEnd;

        public clientWindow()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Client_button_connect_Click(object sender, EventArgs e)
        {
            //创建新客户端socket连接
            try
            {
                clientEnd = new Client.Client(IPAddress.Parse(client_ip.Text),Convert.ToInt32(client_port.Text));
                clientEnd.Connect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Client_button_send_Click(object sender, EventArgs e)
        {
            try
            {
                clientEnd.Send(Encoding.UTF8.GetBytes(client_message.Text));
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void Client_button_disconnect_Click(object sender, EventArgs e)
        {
            try { clientEnd.Disconnect(); }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            serverWindow server = new serverWindow();
            server.Show();
        }
    }
}
