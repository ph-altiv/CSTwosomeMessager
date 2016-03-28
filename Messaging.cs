using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CSTwosomeMessager
{
    public static class Messaging
    {
        private static TcpClient ts, tr;
        private static TcpListener tl;
        private static BinaryWriter bw;
        private static BinaryReader br;
        private static Queue<string> messageBuffer;
        private static Thread tGettingMessages;
        private static Object bufferLock;

        private static void GettingMessages()
        {
            string msg;
            while(true)
            {
                msg = br.ReadString();
                lock(bufferLock)
                {
                    messageBuffer.Enqueue(msg);
                }
            }
        }

        private static void CreateTcpListener(int port)
        {
            tl = new TcpListener(IPAddress.Any, port);
            tl.Start();
            tr = tl.AcceptTcpClient();
            br = new BinaryReader(tr.GetStream());
            messageBuffer = new Queue<string>();
            bufferLock = new Object();
            tGettingMessages = new Thread(new ThreadStart(GettingMessages));
        }

        private static void CreateTcpClient(string hostname, int port)
        {
            ts = new TcpClient(hostname, port);
            bw = new BinaryWriter(ts.GetStream());
        }

        public static void CreateServer(int serverport)
        {
            CreateTcpListener(serverport);
            int clientport = br.ReadInt32();
            string clienthostname = ((IPEndPoint)tr.Client.RemoteEndPoint).Address.ToString();
            CreateTcpClient(clienthostname, clientport);
        }

        public static void CreateClient(string serverhostname, int serverport, int clientport)
        {
            CreateTcpClient(serverhostname, serverport);
            bw.Write(clientport);
            CreateTcpListener(clientport);
        }
        public static string GetMsg()
        {
            while (messageBuffer.Count <= 0)
                Thread.Sleep(100);
            lock (bufferLock)
            return messageBuffer.Dequeue();
        }
    }
}
