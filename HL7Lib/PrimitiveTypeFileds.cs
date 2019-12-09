using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    /// <summary>
    /// 字段ID，简单类型
    /// </summary>
    public class ID : PrimitiveType
    {
        public ID(string name):base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段SI，简单类型
    /// </summary>
    public class SI : PrimitiveType
    {
        public SI(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段TS，简单类型
    /// </summary>
    public class TS : PrimitiveType
    {
        public TS(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段FT，简单类型
    /// </summary>
    public class FT : PrimitiveType
    {
        public FT(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段TX，简单类型
    /// </summary>
    public class TX : PrimitiveType
    {
        public TX(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段TN，简单类型
    /// </summary>
    public class TN : PrimitiveType
    {
        public TN(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段TM，简单类型
    /// </summary>
    public class TM : PrimitiveType
    {
        public TM(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段DT，简单类型
    /// </summary>
    public class DT : PrimitiveType
    {
        public DT(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段ST，简单类型
    /// </summary>
    public class ST : PrimitiveType
    {
        public ST(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段NM，简单类型
    /// </summary>
    public class NM : PrimitiveType
    {
        public NM(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }

    /// <summary>
    /// 字段IS，简单类型
    /// </summary>
    public class IS : PrimitiveType
    {
        public IS(string name) : base(name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return value;
        }
        public override bool Parse(string text)
        {
            this.value = text;
            return true;
        }
    }
}
