using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7DataType
{
    /// <summary>
    /// HL7消息
    /// </summary>
    public class HL7_Message: CompositeData
    {

    }

    /// <summary>
    /// HL7段
    /// </summary>
    public class Segment: CompositeData
    {
        public List<Data> data;
        private CompositeData parent;
        private string name;

        public Segment(CompositeData parent, string name)
        {
            this.parent = parent;
            this.name = name;
        }
    }

    /// <summary>
    /// HL7复合类型与简单类型的抽象类
    /// </summary>
    public abstract class Data
    {

    }

    /// <summary>
    /// HL7复合类型数据
    /// </summary>
    public class CompositeData:Data
    {
        public List<Data> subData;
    }

    /// <summary>
    /// HL7简单类型数据
    /// </summary>
    public class SimpleData:Data
    {

    }


    public class CE : Segment
    {
        public CE(CompositeData parent, string name) : base(parent, name)
        {
            data[0] = new ST("Identifier");
            data[1] = new ST("Text");
            data[2] = new ST("Name Of Coding System");
        }
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

        public ST NameOfAlternateCodingSystem
        {
            get { return data[2] as ST; }
            set { data[2] = value; }
        }
    }

    public class ST:SimpleData
    {
        public string str;
        public ST(string str)
        {
            this.str = str;
        }
    }
}
