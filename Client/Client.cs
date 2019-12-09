using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public class Client
    {
        /// <summary>
        /// 客户端ip地址
        /// </summary>
        private readonly IPAddress ip;

        /// <summary>
        /// 客户端端口
        /// </summary>
        private readonly int port;

        /// <summary>
        /// 客户端套接字
        /// </summary>
        private readonly Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        /// <summary>
        /// 接收服务端消息线程
        /// </summary>
        private readonly Thread receivingData = new Thread(new ParameterizedThreadStart(AcceptMgs));

        /// <summary>
        /// 客户端
        /// </summary>
        /// <param name="ip">ip地址</param>
        /// <param name="port">端口号</param>
        public Client(IPAddress ip, int port)
        {
            //初始化ip与端口
            this.ip = ip;
            this.port = port;
        }

        /// <summary>
        /// 开始连接
        /// </summary>
        public void Connect()
        {
            try
            {
                this.socket.Connect(ip, port);
                receivingData.Start(this.socket);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnect()
        {
            try
            {
                this.socket.Disconnect(true);
                receivingData.Abort();
            }
            catch (Exception e) { throw e; }
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="buffer">要发送的字节流</param>
        public void Send(byte[] buffer)
        {
            try
            {
                int a = buffer.Length;
                byte[] b = new byte[a + 3];
                b[0] = 0x0b;
                for (int i = 1; i < b.Length - 2;i++)
                    b[i] = buffer[i - 1];
                b[b.Length - 1] = 0x0d;
                b[b.Length - 2] = 0x1c;
                socket.Send(b);
            }
            catch (Exception e) { throw e; }
        }

        /// <summary>
        /// 自动获取从server传回的消息，收到消息时触发“从服务端接收消息”事件
        /// </summary>
        private static void AcceptMgs(object _socket)
        {
            try
            {
                while (true)
                {
                    Socket socket = (Socket)_socket;
                    byte[] buffer = new byte[1024 * 1024];
                    int r = socket.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }

                    //接收消息
                    string strMsg = Encoding.UTF8.GetString(buffer, 0, r);

                }
            }
            catch (Exception e) { throw e; }
        }
    }
}
