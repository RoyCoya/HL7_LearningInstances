using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    /// <summary>
    /// EVN段
    /// </summary>
    public class EVN : Segment
    {


        public ID EventTypeCode
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public TS RecordedDateTime
        {
            get { return data[1] as TS; }
            set { data[1] = value; }
        }
        public TS DateTimePlannedEvent
        {
            get { return data[2] as TS; }
            set { data[2] = value; }
        }
        public IS EventReasonCode
        {
            get { return data[3] as IS; }
            set { data[3] = value; }
        }
        public XCN OperatorID
        {
            get { return data[4] as XCN; }
            set { data[4] = value; }
        }
        public TS EventOccurred
        {
            get { return data[5] as TS; }
            set { data[5] = value; }
        }

        public EVN(Message parent, string name) : base(parent, name)
        {
            data = new AbstractType[6];
            data[0] = new ID("EventTypeCode");
            data[1] = new TS("RecordedDateTime");
            data[2] = new TS("DateTimePlannedEvent");
            data[3] = new IS("EventReasonCode");
            data[4] = new XCN(this, "OperatorID");
            data[5] = new TS("EventOccurred");
        }

    }

    /// <summary>
    /// MSH段
    /// </summary>
    public class MSH : Segment
    {
        public ST FieldSeparator {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ST EncodingCharacters
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }
        public HD SendingApplication
        {
            get { return data[2] as HD; }
            set { data[2] = value; }
        }
        public HD SendingFacility
        {
            get { return data[3] as HD; }
            set { data[3] = value; }
        }
        public HD ReceivingApplication
        {
            get { return data[4] as HD; }
            set { data[4] = value; }
        }
        public HD ReceivingFacility
        {
            get { return data[5] as HD; }
            set { data[5] = value; }
        }
        public TS DateTimeOfMessage
        {
            get { return data[6] as TS; }
            set { data[6] = value; }
        }
        public ST Security
        {
            get { return data[7] as ST; }
            set { data[7] = value; }
        }
        public MSG MessageType
        {
            get { return data[8] as MSG; }
            set { data[8] = value; }
        }
        public ST MessageControlID
        {
            get { return data[9] as ST; }
            set { data[9] = value; }
        }
        public PT ProcessingID
        {
            get { return data[10] as PT; }
            set { data[10] = value; }
        }
        public VID VersionID
        {
            get { return data[11] as VID; }
            set { data[11] = value; }
        }
        public NM SequenceNumber
        {
            get { return data[12] as NM; }
            set { data[12] = value; }
        }
        public ST ContinuationPointer
        {
            get { return data[13] as ST; }
            set { data[13] = value; }
        }
        public ID AcceptAcknowledgmentType
        {
            get { return data[14] as ID; }
            set { data[14] = value; }
        }
        public ID ApplicationAcknowledgmentType
        {
            get { return data[15] as ID; }
            set { data[15] = value; }
        }
        public ID CountryCode
        {
            get { return data[16] as ID; }
            set { data[16] = value; }
        }
        public ID CharacterSet
        {
            get { return data[17] as ID; }
            set { data[17] = value; }
        }
        public CE PrincipalLanguageOfMessage
        {
            get { return data[18] as CE; }
            set { data[18] = value; }
        }
        public ID AlternateCharacterSetHandlingScheme
        {
            get { return data[19] as ID; }
            set { data[19] = value; }
        }
        public EI MessageProfileIdentifier
        {
            get { return data[20] as EI; }
            set { data[20] = value; }
        }
        public MSH(Message parent, string name) : base(parent, name)
        {
            data = new AbstractType[21];
            data[0] = new ST("Field Separator");
            data[1] = new ST("Encoding Characters");
            data[2] = new HD(this, "Sending Application");
            data[3] = new HD(this, "Sending Facility");
            data[4] = new HD(this, "Receiving Application");
            data[5] = new HD(this, "Receiving Facility");
            data[6] = new TS("Date/Time Of Message");
            data[7] = new ST("Security");
            data[8] = new MSG(this, "Message Type");
            data[9] = new ST("Message Control ID");
            data[10] = new PT(this, "Processing ID");
            data[11] = new VID(this, "Version ID");
            data[12] = new NM("Sequence Number");
            data[13] = new ST("Continuation Pointer");
            data[14] = new ID("Accept Acknowledgment Type");
            data[15] = new ID("Application Acknowledgment Type");
            data[16] = new ID("Country Code");
            data[17] = new ID("Character Set");
            data[18] = new CE(this, "Principal Language Of Message");
            data[19] = new ID("Alternate Character Set Handling Scheme");
            data[20] = new EI(this,"Message Profile Identifier");
        }

        public override bool Parse(string text)
        {
            this.value = text;

            string[] splitResult = text.Split(this.delimiter);
            try
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (splitResult[i] == null || splitResult[i].Length == 0) continue;
                    data[i].Parse(splitResult[i]);
                }
            }
            catch { }
            data[0].Value = text[3].ToString();
            return true;
        }

        
    }

    /// <summary>
    /// MSA段
    /// </summary>
    public class MSA : Segment
    {
        public ID AcknowledgmentCode
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public ST MessageControlID
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }
        public ST TextMessage
        {
            get { return data[2] as ST; }
            set { data[2] = value; }
        }
        public NM ExpectedSequenceNumber
        {
            get { return data[3] as NM; }
            set { data[3] = value; }
        }
        public ID DelayedAcknowledgmentType
        {
            get { return data[4] as ID; }
            set { data[4] = value; }
        }
        public CE ErrorCondition
        {
            get { return data[5] as CE; }
            set { data[5] = value; }
        }


        public MSA(Message parent, string name) : base(parent, name)
        {
            data = new AbstractType[6];
            data[0] = new ID("Field Separator");
            data[1] = new ST("Encoding Characters");
            data[2] = new ST("Sending Application");
            data[3] = new NM("Sending Facility");
            data[4] = new ID("Receiving Application");
            data[5] = new CE(this, "Receiving Facility");
        }


    }

    /// <summary>
    /// ERR段
    /// </summary>
    public class ERR : Segment
    {
        public ELD ErrorCodeandLocation
        {
            get { return data[0] as ELD ; }
            set { data[0] = value; }
        }
        public ERL ErrorLocation
        {
            get { return data[1] as ERL; }
            set { data[1] = value; }
        }
        public CWE HL7ErrorCode
        {
            get { return data[2] as CWE; }
            set { data[2] = value; }
        }
        public ID Severity
        {
            get { return data[3] as ID; }
            set { data[3] = value; }
        }
        public CWE ApplicationErrorCode
        {
            get { return data[4] as CWE; }
            set { data[4] = value; }
        }
        public ST ApplicationErrorParameter
        {
            get { return data[5] as ST; }
            set { data[5] = value; }
        }
        public TX DiagnosticInformation
        {
            get { return data[6] as TX; }
            set { data[6] = value; }
        }
        public TX UserMessage
        {
            get { return data[7] as TX; }
            set { data[6] = value; }
        }
        public IS InformPersonIndicator
        {
            get { return data[7] as IS; }
            set { data[6] = value; }
        }
        public CWE OverrideType
        {
            get { return data[8] as CWE; }
            set { data[8] = value; }
        }
        public CWE OverrideReasonCode
        {
            get { return data[9] as CWE; }
            set { data[9] = value; }
        }
        public XTN HelpDeskContactPoint
        {
            get { return data[10] as XTN; }
            set { data[10] = value; }
        }


        public ERR(Message parent, string name) : base(parent, name)
        {
            data = new AbstractType[12];
            data[0] = new ELD(this, "Error Code and Location");
            data[1] = new ERL(this, "Error Location");
            data[2] = new CWE(this, "HL7 Error Code");
            data[3] = new ID("Severity");
            data[4] = new CWE(this, "Application Error Code");
            data[5] = new ST("Application Error Parameter");
            data[6] = new TX("Diagnostic Information");
            data[7] = new TX("User Message");
            data[8] = new IS("Inform Person Indicator");
            data[9] = new CWE(this, "Override Type");
            data[10] = new CWE(this, "Override Reason Code");
            data[11] = new XTN(this, "Help Desk Contact Point");
        }

    }
}
