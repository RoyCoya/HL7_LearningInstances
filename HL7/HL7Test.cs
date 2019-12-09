using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HL7Factory;
using HL7Lib;

namespace HL7
{
    public partial class HL7Test : Form
    {
        public HL7Test()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageFactory factory = new MessageFactory();
            ACK msg = factory.Create(null, MessageFactory.MessageType.ACK, "ACK") as ACK;
            msg.msh.FieldSeparator.Value = "|";
            msg.msh.EncodingCharacters.Value = "^~\\&";
            msg.msh.DateTimeOfMessage.Value = DateTime.Now.ToString("yyyyMMddhhmmss.fff");
            msg.msh.MessageType.MessageCode.Value = "ACK";
            msg.msh.MessageType.TriggerEvent.Value = "A01";
            msg.msh.MessageType.MessageStructure.Value = "ACK_A01";
            msg.msh.MessageControlID.Value = "A00002";
            msg.msh.ProcessingID.ProcessingID.Value = "P";
            msg.msh.VersionID.VersionID.Value = "2.4";
            msg.msa.AcknowledgmentCode.Value = "AA";
            msg.msa.MessageControlID.Value = "MSG00001";
            msg.msa.TextMessage.Value = "Success";

            richTextBox1.Text = msg.ToString();

        }
    }
}

