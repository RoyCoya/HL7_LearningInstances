using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    /// <summary>
    /// 字段HD，复杂类型
    /// </summary>
    public class HD : compositeField
    {
        public IS NamespaceID
        {
            get { return (IS)data[0]; }
            set { }
        }
        public ST UniversalID
        {
            get { return (ST)data[1]; }
            set { }
        }
        public ID UniversalIDType
        {
            get { return (ID)data[2]; }
            set { }
        }

        public HD(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[3];
            data[0] = new IS("NamespaceID");
            data[1] = new ST("UniversalID");
            data[2] = new ID("UniversalIDType");
        }
    }
    
    /// <summary>
    /// 字段MSG，复杂类型
    /// </summary>
    public class MSG : compositeField
    {
        public ID MessageCode
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public ID TriggerEvent
        {
            get { return data[1] as ID; }
            set { data[1] = value; }
        }
        public ID MessageStructure
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }

        public MSG(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[3];
            data[0] = new ID("MessageCode");
            data[1] = new ID("TriggerEvent");
            data[2] = new ID("MessageStructure");
        }
    }

    /// <summary>
    /// 字段EI，复杂类型
    /// </summary>
    public class EI : compositeField
    {
        public ST EntityIdentifier
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public IS NamespaceID
        {
            get { return data[1] as IS; }
            set { data[1] = value; }
        }
        public ID UniversalIDType
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }


        public EI(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[3];
            data[0] = new ST("EntityIdentifier");
            data[1] = new IS("NamespaceID");
            data[2] = new ID("UniversalIDType");
        }
    }

    /// <summary>
    /// 字段CE，复杂类型
    /// </summary>
    public class CE : compositeField
    {
        public ST Identifier
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ST Text
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }
        public ID NameOfCodingSystem
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }
        public ST AlternateIdentifier
        {
            get { return data[3] as ST; }
            set { data[3] = value; }
        }
        public ST AlternateText
        {
            get { return data[4] as ST; }
            set { data[4] = value; }
        }
        public ID NameOfAlternateCodingSystem
        {
            get { return data[5] as ID; }
            set { data[5] = value; }
        }

        public CE(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[6];
            data[0] = new ST("Identifier");
            data[1] = new ST("Text");
            data[2] = new ID("NameOfCodingSystem");
            data[3] = new ST("AlternateIdentifier");
            data[4] = new ST("AlternateText");
            data[5] = new ID("NameOfAlternateCodingSystem");
        }
    }

    /// <summary>
    /// 字段VID，复杂类型
    /// </summary>
    public class VID : compositeField
    {
        public ID VersionID
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public CE Internationalizationcode
        {
            get { return data[1] as CE; }
            set { data[1] = value; }
        }
        public CE InternationalVersionID
        {
            get { return data[2] as CE; }
            set { data[2] = value; }
        }

        public VID(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[3];
            data[0] = new ID("VersionID");
            data[1] = new CE(this,"Internationalizationcode");
            data[2] = new CE(this,"InternationalVersionID");
        }
    }

    /// <summary>
    /// 字段PT，复杂类型
    /// </summary>
    public class PT : compositeField
    {
        public ID ProcessingID
        {
            get { return data[0] as ID; }
            set { data[0] = value; }
        }
        public ID ProcessingMode
        {
            get { return data[1] as ID; }
            set { data[1] = value; }
        }

        public PT(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[2];
            data[0] = new ID("ProcessingID");
            data[1] = new ID("ProcessingMode");
        }
    }
    /// <summary>
    /// 字段ELD，复杂类型
    /// </summary>
    public class ELD : compositeField
    {
        public ST SegmentID
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public NM SegmentSequence
        {
            get { return data[1] as NM; }
            set { data[1] = value; }
        }
        public NM FieldPosition
        {
            get { return data[2] as NM; }
            set { data[2] = value; }
        }
        public CE CodeIdentifyingError
        {
            get { return data[3] as CE; }
            set { data[3] = value; }
        }

        public ELD(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[4];
            data[0] = new ST("SegmentID");
            data[1] = new NM("SegmentSequence");
            data[2] = new NM("FieldPosition");
            data[3] = new CE(this, "CodeIdentifyingError");
        }
    }

    /// <summary>
    /// 字段ERL，复杂类型
    /// </summary>
    public class ERL : compositeField
    {
        public ST SegmentID
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public NM SegmentSequence
        {
            get { return data[1] as NM; }
            set { data[1] = value; }
        }
        public NM FieldPosition
        {
            get { return data[2] as NM; }
            set { data[2] = value; }
        }
        public NM FieldRepeition
        {
            get { return data[3] as NM; }
            set { data[3] = value; }
        }
        public NM ComponentNumber
        {
            get { return data[4] as NM; }
            set { data[4] = value; }
        }
        public NM SubComponentNumber
        {
            get { return data[5] as NM; }
            set { data[5] = value; }
        }

        public ERL(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[6];
            data[0] = new ST("SegmentID");
            data[1] = new NM("SegmentSequence");
            data[2] = new NM("FieldPosition");
            data[3] = new NM("FieldRepeition");
            data[4] = new NM("ComponentNumber");
            data[5] = new NM("SubComponentNumber");
        }
    }

    /// <summary>
    /// 字段CWE，复杂类型
    /// </summary>
    public class CWE : compositeField
    {
        public ST Identifier
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ST Text
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }
        public ID NameOfCodingSystem
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }
        public ST AlternateIdentifier
        {
            get { return data[3] as ST; }
            set { data[3] = value; }
        }
        public ST AlternateText
        {
            get { return data[4] as ST; }
            set { data[4] = value; }
        }
        public ID NameOfAlternateCodingSystem
        {
            get { return data[5] as ID; }
            set { data[5] = value; }
        }
        public ST CodingSystemVersionID
        {
            get { return data[6] as ST; }
            set { data[6] = value; }
        }
        public ST AlternateCodingSystemVersionID
        {
            get { return data[7] as ST; }
            set { data[7] = value; }
        }
        public ST OriginalText
        {
            get { return data[8] as ST; }
            set { data[8] = value; }
        }

        public CWE(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[9];
            data[0] = new ST("Identifier");
            data[1] = new ST("Text");
            data[2] = new ID("NameOfCodingSystem");
            data[3] = new ST("AlternateIdentifier");
            data[4] = new ST("AlternateText");
            data[5] = new ID("NameOfAlternateCodingSystem");
            data[6] = new ST("CodingSystemVersionID");
            data[7] = new ST("AlternateCodingSystemVersionID");
            data[8] = new ST("OriginalText");
        }
    }

    /// <summary>
    /// 字段XTN，复杂类型
    /// </summary>
    public class XTN : compositeField
    {
        public ST TelephoneNumber
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ID TelecommunicationUseCode
        {
            get { return data[1] as ID; }
            set { data[1] = value; }
        }
        public ID TelecommunicationEquipmentType
        {
            get { return data[2] as ID; }
            set { data[2] = value; }
        }
        public ST EmailAddress
        {
            get { return data[3] as ST; }
            set { data[3] = value; }
        }
        public NM CountryCode
        {
            get { return data[4] as NM; }
            set { data[4] = value; }
        }
        public NM AreaCityCode
        {
            get { return data[5] as NM; }
            set { data[5] = value; }
        }
        public NM LocalNumber
        {
            get { return data[6] as NM; }
            set { data[6] = value; }
        }
        public NM Extension
        {
            get { return data[7] as NM; }
            set { data[7] = value; }
        }
        public ST AnyText
        {
            get { return data[8] as ST; }
            set { data[8] = value; }
        }
        public ST ExtensionPrefix
        {
            get { return data[9] as ST; }
            set { data[9] = value; }
        }
        public ST SpeedDialCode
        {
            get { return data[10] as ST; }
            set { data[10] = value; }
        }
        public ST UnformattedTelephoneNumber
        {
            get { return data[11] as ST; }
            set { data[11] = value; }
        }

        public XTN(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[12];
            data[0] = new ST("TelephoneNumber");
            data[1] = new NM("TelecommunicationUseCode");
            data[2] = new NM("TelecommunicationEquipmentType");
            data[3] = new NM("EmailAddress");
            data[4] = new NM("CountryCode");
            data[5] = new NM("AreaCityCode");
            data[6] = new NM("LocalNumber");
            data[7] = new NM("Extension");
            data[8] = new NM("AnyText");
            data[9] = new NM("ExtensionPrefix");
            data[10] = new NM("SpeedDialCode");
            data[11] = new NM("UnformattedTelephoneNumber");
        }

    }
    
    /// <summary>
    /// 字段XCN，复杂类型
    /// </summary>
    public class XCN : compositeField
    {
        public ST IdNumber
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public FN FamilyNameLastName
        {
            get { return data[1] as FN; }
            set { data[1] = value; }
        }
        public ST GivenName
        {
            get { return data[2] as ST; }
            set { data[2] = value; }
        }
        public ST MiddleInitialOrName
        {
            get { return data[3] as ST; }
            set { data[3] = value; }
        }
        public ST Suffix
        {
            get { return data[4] as ST; }
            set { data[4] = value; }
        }
        public ST Prefix
        {
            get { return data[5] as ST; }
            set { data[5] = value; }
        }
        public IS Degree
        {
            get { return data[6] as IS; }
            set { data[6] = value; }
        }
        public IS SourceTable
        {
            get { return data[7] as IS; }
            set { data[7] = value; }
        }
        public HD AssigningAuthority
        {
            get { return data[8] as HD; }
            set { data[8] = value; }
        }
        public ID NameTypeCode
        {
            get { return data[9] as ID; }
            set { data[9] = value; }
        }
        public ST IdentifierCheckDigit
        {
            get { return data[10] as ST; }
            set { data[10] = value; }
        }
        public ID CodeIdentifyingTheCheckDigitSchemeEmployed
        {
            get { return data[11] as ID; }
            set { data[11] = value; }
        }
        public IS IdentifierTypeCode
        {
            get { return data[12] as IS; }
            set { data[12] = value; }
        }
        public HD AssigningFacility
        {
            get { return data[13] as HD; }
            set { data[13] = value; }
        }
        public ID NameRepresentationCode
        {
            get { return data[14] as ID; }
            set { data[14] = value; }
        }

        public XCN(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[12];
            data[0] = new ST("IdNumber");
            data[1] = new FN(this, "FamilyNameLastName");
            data[2] = new ST("GivenName");
            data[3] = new ST("MiddleInitialOrName");
            data[4] = new ST("Suffix");
            data[5] = new ST("Prefix");
            data[6] = new IS("Degree");
            data[7] = new IS("SourceTable");
            data[8] = new HD(this, "AssigningAuthority");
            data[9] = new ID("NameTypeCode");
            data[10] = new ST("IdentifierCheckDigit");
            data[11] = new ID("UnformCodeIdentifyingTheCheckDigitSchemeEmployedattedTelephoneNumber");
            data[12] = new IS("IdentifierTypeCode");
            data[13] = new HD(this, "AssigningFacility");
            data[14] = new ID("NameRepresentationCode");
        }

    }

    /// <summary>
    /// 字段FN，复杂类型
    /// </summary>
    public class FN : compositeField
    {
        public ST FamilyName
        {
            get { return data[0] as ST; }
            set { data[0] = value; }
        }
        public ST LastNamePrefix
        {
            get { return data[1] as ST; }
            set { data[1] = value; }
        }

        public FN(CompositeType parent, string name) : base(parent, name)
        {
            data = new AbstractType[2];
            data[0] = new ST("FamilyName");
            data[1] = new ST("LastNamePrefix");
        }
    }
}
