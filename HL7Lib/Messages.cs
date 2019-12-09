using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib
{
    public class ACK:Message
    {
        public MSH msh
        {
            get { return data[0] as MSH; }
            set { data[0] = value; }
        }

        public MSA msa
        {
            get { return data[1] as MSA; }
            set { data[0] = value; }
        }
        public ERR err
        {
            get { return data[2] as ERR; }
            set { data[0] = value; }
        }

        public ACK(AbstractType parent,string name) : base(null, name)
        {
            data = new Segment[3];
            data[0] = new MSH(this,"MSH");
            data[1] = new MSA(this, "MSA");
            data[2] = new ERR(this, "ERR");
        }
    }
}
