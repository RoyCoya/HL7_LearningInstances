using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    public static class Common
    {
        public static string version = "2.4";
        public static char segmentDelimiter = '\r';
        public static char fieldDelimiter = '|';
        public static char componentDelimiter = '^';
        public static char subComponentDelimiter = '&';
        public static char repeatDelimiter = '~';
        public static char escapeDelimiter = '\\';
    }

    public abstract class AbstractType
    {
        public string name;
        public string value;
        public string Name { get { return this.name; } }
        public string Version { get { return Common.version;} }
        public string Value
        {
            get { return this.ToString(); }
            set { this.Parse(value); }
        }
        public AbstractType(string name)
        {
            this.name = name;
        }

        public abstract bool Parse(string text);
        public abstract override string ToString();
    }

    public abstract class PrimitiveType : AbstractType
    {
        public PrimitiveType(string name) : base(name)
        {
            base.name = name;
        }
        public override string ToString()
        {
            return value;
        }
    }

    public abstract class CompositeType : AbstractType
    {
        public char delimiter;
        protected AbstractType[] data;

        public CompositeType(CompositeType parent, string name) : base(name)
        {
            base.name = name;
            if (parent == null)
                delimiter = Common.segmentDelimiter;
            else if (parent.delimiter == Common.segmentDelimiter)
                delimiter = Common.fieldDelimiter;
            else if (parent.delimiter == Common.fieldDelimiter)
                delimiter = Common.componentDelimiter;
            else if (parent.delimiter == Common.componentDelimiter)
                delimiter = Common.subComponentDelimiter;
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

            return true;
        }

        public override string ToString()
        {
            int omitIdx = 0;
            string result = "";

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (!(data[i].ToString() == null))
                    omitIdx = i;
            }

            for (int j = 0; j < omitIdx + 1; j++)
            {
                if (j == omitIdx)
                    result += data[j].ToString();
                else result += data[j].ToString() + this.delimiter;
            }

            if (result == "")
                return null;
            else return result;
        }
    }

    public class Message : CompositeType
    {
        public Message(CompositeType parent, string name) : base(null, name)
        {

        }
    }

    public class Segment : CompositeType
    {
        public Segment(Message parent, string name) : base(parent, name)
        {

        }
        public override bool Parse(string text)
        {
            int idx = text.Split(this.delimiter)[0].Length;
            text = text.Substring(idx + 1);
            return base.Parse(text);
        }

        public override string ToString()
        {
            int omitIdx = 0;
            string result = this.name + "|";

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (!(data[i].ToString() == null))
                    omitIdx = i;
            }

            for (int j = 1; j < omitIdx + 1; j++)
            {
                if (j == omitIdx)
                    result += data[j].ToString();
                else result += data[j].ToString() + this.delimiter;
            }

            if(result == this.name + "|")
                return null;
            else return result;
        }
    }

    public class compositeField : CompositeType
    {
        public compositeField(CompositeType parent, string name) : base(parent, name)
        {

        }
    }
}
