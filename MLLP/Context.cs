using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLLP
{
    public class Context
    {
        
        /// <summary>
        /// 存储输入的字节流
        /// </summary>
        public byte[] buff;
        /// <summary>
        /// 字节流存储buff的索引
        /// </summary>
        public int idx;
        /// <summary>
        /// 当前Context的状态：【WAIT,DATA,END】
        /// </summary>
        States state;
        /// <summary>
        /// 状态枚举。WAIT:等待消息。DATA:消息开始。END:消息结束。
        /// </summary>
        public enum EnumState { WAIT, DATA, END }

        /// <summary>
        /// 事件枚举。SB:HL7消息开始。EB:HL7消息结束。CR:HL7消息换行。
        /// </summary>
        public enum EnumEvent { SB = 0x0b, EB = 0x1c, CR = 0x0d } //事件枚举

        /// <summary>
        /// 事件：消息接受完成
        /// </summary>
        public event EventHandler<MSGEventArgs> EventMsgReceived;

        /// <summary>
        /// Context初始化，状态改WAIT，idx归零，buff清空
        /// </summary>
        public Context()
        {
            buff = new byte[65536];
            idx = 0;
            ChangeState(EnumState.WAIT);
        }

        /// <summary>
        /// 把ch保存到消息缓存区
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public void BufferIn(byte ch)
        {
            buff[idx] = ch;
            idx += 1;
        }

        /// <summary>
        /// 改变当前状态。stateAfterChange：改变后的状态（从状态枚举中调取）
        /// </summary>
        /// <param name="stateAfterChange"></param>
        public void ChangeState(EnumState stateAfterChange)
        {
            switch (stateAfterChange)
            {
                case EnumState.WAIT:
                    this.state = new WaitState();
                    break;
                case EnumState.DATA:
                    this.state = new DataState();
                    break;
                case EnumState.END:
                    this.state = new EndState();
                    break;
                default: throw new Exception("状态错误：没有找到该状态");
            }
        }

        /// <summary>
        /// 缓存初始化
        /// </summary>
        public void InitBuff()
        {
            buff = new byte[65536];
            idx = 0;
        }

        /// <summary>
        /// 字节流输入接口
        /// </summary>
        /// <param name="data"></param>
        public void Input(byte[] data)
        {
            foreach(byte ch in data)
            {
                state.Handle(this, ch);
            }
            Console.Write("\n***字节流处理完成***\n");
        }

        /// <summary>
        /// 消息接收完成，触发HL7消息接收事件
        /// </summary>
        public void MsgProc()
        {
            string msg = Encoding.UTF8.GetString(buff);
            msg = msg.TrimEnd('\0');
            MSGEventArgs e = new MSGEventArgs(msg);
            EventMsgReceived(this,e);
        }

        /// <summary>
        /// 消息事件相关信息
        /// </summary>
        public class MSGEventArgs : EventArgs
        {  
            public string msg;    //HL7消息
            public MSGEventArgs(string msg)
            {
                this.msg = msg;
            }
        }
    }
}
