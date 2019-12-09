using Microsoft.VisualStudio.TestTools.UnitTesting;
using HL7Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7Lib.Tests
{
    [TestClass()]
    public class abstractTypeTests
    {
        [TestMethod()]
        public void CompositeTypeTest()
        {

        }

        [TestMethod()]
        public void ToStringTest()
        {

        }

        [TestMethod()]
        public void ParseTest()
        {

        }

        [TestMethod()]
        public void compositeFieldTest()
        {
            Message ACK = new ACK(null, "ACK");
            ACK.Parse("MSH|^~\\&|LABADT|DH|EPICADT|DH|201301011228||ACK^A01^ACK |HL7ACK00001|P|2.3\rMSA|AA|HL7MSG00001");
        }
    }

    [TestClass()]
    public class AbstractTypeTests
    {
        [TestMethod()]
        public void AbstractTypeTest()
        {

        }

        [TestMethod()]
        public void ParseTest()
        {

        }

        [TestMethod()]
        public void ToStringTest()
        {
            
        }
    }
}