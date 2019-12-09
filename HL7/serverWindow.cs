using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;
using System.Net;

namespace HL7
{
    public partial class serverWindow : Form
    {
        Server.Server serverEnd;

        public serverWindow()
        {
            InitializeComponent();
        }

        private void Server_button_listen_Click(object sender, EventArgs e)
        {
            try
            {
                serverEnd = new Server.Server(IPAddress.Parse(server_ip.Text),Convert.ToInt32(server_port.Text));
                serverEnd.StartListen();
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
