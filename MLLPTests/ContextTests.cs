using Microsoft.VisualStudio.TestTools.UnitTesting;
using MLLP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MLLP.Context;

namespace MLLP.Tests
{
    [TestClass()]
    public class ContextTests
    {
        [TestMethod()]
        public void ContextTest()
        {
            string case1 = "afa\x0bMSH|1||||\rMSA|2||||||\r\x1c\x0dvdb";  //测试用例
            Context ctx = new Context();//实例化Context对象
            ctx.EventMsgReceived += Context_eventMsgReceived;
            ctx.Input(Encoding.Default.GetBytes(case1));//用测试用例进行测试
        }
        
        [TestMethod()]
        //在ctx_eventMsgReceived方法中接收消息，校验结果是否正确
        void Context_eventMsgReceived(object sender, EventArgs e)
        {
            Context context = (Context)sender;
            int idx = 0;
            string[] result1 = { "MSH|1||||\rMSA|2||||||\r" };         //正确结果
            MSGEventArgs evt = e as MSGEventArgs;
            System.Diagnostics.Debug.WriteLine(evt.msg);  //调试时显示到输出窗口
            Assert.AreEqual(result1[idx++], evt.msg);//与正确结果比较
        }

    }
}