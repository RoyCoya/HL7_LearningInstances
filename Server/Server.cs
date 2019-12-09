using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public class Server
    {
        /// <summary>
        /// 服务端ip地址
        /// </summary>
        private readonly IPAddress ip;

        /// <summary>
        /// 服务端端口
        /// </summary>
        private readonly int port;

        public Dictionary<string, Socket> connections = new Dictionary<string, Socket>();
        private readonly Socket socketListen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Server(IPAddress ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        public void StartListen()
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(ip, port);
                this.socketListen.Bind(endPoint);
                this.socketListen.Listen(5);
                Thread td = new Thread(AcceptMgs);
                td.Start(this);
            }
            catch (Exception e) { throw e; }
        }

        public void StopListen()
        {
            try
            {
                this.socketListen.Close();
            }
            catch(Exception e) { throw e; }
        }

        private static void AcceptMgs(object o)
        {
            try
            {
                Server server = (Server)o;
                while (true)
                {
                    ////负责跟客户端通信的Socket
                    Socket socketSend = server.socketListen.Accept();

                    //将远程连接的客户端的IP地址和Socket存入集合中
                    server.connections.Add(socketSend.RemoteEndPoint.ToString(), socketSend);

                    //新建线程循环接收客户端发来的信息
                    Thread td = new Thread(Recive);
                    td.IsBackground = true;
                    td.Start(socketSend);
                }
            }
            catch (Exception e) { throw e; }
        }


        /// <summary>
        /// 接收客户端发来的数据，并显示出来
        /// </summary>
        private static void Recive(object o)
        {
            Socket socketSend = (Socket)o;
            try
            {
                while (true)
                {
                    //客户端连接成功后，服务器应该接受客户端发来的消息

                    if (socketSend == null)
                    {
                        continue;
                    }

                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffer);
                    //如果客户端关闭，发送的数据就为空，然后就跳出循环
                    if (r == 0)
                    {
                        break;
                    }

                    //接收客户端信息
                    string strMsg = Encoding.UTF8.GetString(buffer, 0, r);

                    byte[] acceptbuffer = Encoding.UTF8.GetBytes("服务器端接收成功");

                    //将字节数组传递给客户端
                    socketSend.Send(acceptbuffer);

                }
            }
            catch(Exception e) { throw e; }

        }
    }
}
