using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V231;
using NHapi.Model.V231.Message;
using NHapi.Model.V231.Segment;

namespace NHAPI_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ADT_A04 message = new ADT_A04();
            message.MSH.FieldSeparator.Value = @"|";
            message.MSH.EncodingCharacters.Value = @"^~\&";
            message.MSH.SendingApplication.NamespaceID.Value = "REGADT";
            message.MSH.SendingFacility.NamespaceID.Value = "MCM";
            message.MSH.ReceivingApplication.NamespaceID.Value = "IFENG";
            message.MSH.DateTimeOfMessage.TimeOfAnEvent.Value = "199901101501";
            message.MSH.MessageType.MessageType.Value = "ADT";
            message.MSH.MessageType.TriggerEvent.Value = "A04";
            message.MSH.MessageControlID.Value = "00001";
            message.MSH.ProcessingID.ProcessingID.Value = "P";
            message.MSH.VersionID.VersionID.Value = "2.3.1";

            message.EVN.EventTypeCode.Value = "A04";
            message.EVN.RecordedDateTime.TimeOfAnEvent.Value = "199901101500";
            message.EVN.DateTimePlannedEvent.TimeOfAnEvent.Value = "199901101400";
            message.EVN.EventReasonCode.Value = "01";
            message.EVN.EventOccurred.TimeOfAnEvent.Value = "199901101410";

            message.PID.GetPatientIdentifierList(0).ID.Value= "191919";
            message.PID.GetPatientIdentifierList(0).AssigningAuthority.NamespaceID.Value = "GENHOS";
            message.PID.GetPatientIdentifierList(0).IdentifierTypeCode.Value = "MR";
            message.PID.GetPatientIdentifierList(1).ID.Value = "371-66-9256";
            message.PID.GetPatientIdentifierList(1).AssigningAuthority.NamespaceID.Value = "USSSA";
            message.PID.GetPatientIdentifierList(1).IdentifierTypeCode.Value = "SS";
            message.PID.GetAlternatePatientIDPID(0).ID.Value = "253763";
            message.PID.GetPatientName(0).FamilyLastName.FamilyName.Value = "MASSIE";
            message.PID.GetPatientName(0).GivenName.Value = "JAMES";
            message.PID.GetPatientName(0).MiddleInitialOrName.Value = "A";
            message.PID.DateTimeOfBirth.TimeOfAnEvent.Value = "19560129";
            message.PID.Sex.Value = "M";
            message.PID.GetPatientAddress(0).StreetAddress.Value = "171 ZOBERLEIN";
            message.PID.GetPatientAddress(0).City.Value = "ISHPEMING";
            message.PID.GetPatientAddress(0).StateOrProvince.Value = "MI";
            message.PID.GetPatientAddress(0).ZipOrPostalCode.Value = "49849";
            message.PID.GetPatientAddress(0).Country.Value = null;
            message.PID.GetPhoneNumberHome(0).Get9999999X99999CAnyText.Value = "(90 0)485-5344";
            message.PID.GetPhoneNumberBusiness(0).Get9999999X99999CAnyText.Value = "(900)485-5344";
            message.PID.MaritalStatus.Identifier.Value = "S";
            message.PID.Religion.Identifier.Value = "C";
            message.PID.PatientAccountNumber.ID.Value = "10199925";
            message.PID.PatientAccountNumber.AssigningAuthority.NamespaceID.Value = "GENHOS";
            message.PID.PatientAccountNumber.IdentifierTypeCode.Value = "AN";
            message.PID.SSNNumberPatient.Value = "371-66-9256";

            PipeParser parser = new PipeParser();

            richTextBox1.Text = parser.Encode(message);
        }
    }
}
