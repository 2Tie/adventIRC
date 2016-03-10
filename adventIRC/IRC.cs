using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace adventIRC
{
    class IRC
    {
        public TcpClient tcp;
        public StreamReader sR;
        public StreamWriter sW;

        public string nickName;

        public IRC (string hostname, int port, string name)
        {
            tcp = new TcpClient(hostname, port);
            sR = new StreamReader(tcp.GetStream());
            sW = new StreamWriter(tcp.GetStream());
            nickName = name;

            //Connect. the order is PASS, NICK, USER
            //if (pass.Length != 0)
            //sW.WriteLine("PASS " + pass);
            sW.WriteLine("NICK " + name);
            sW.WriteLine("USER " + name + " foo bar :" + name);

            sW.Flush();
        }

        public void joinRoom(string chan, string pass)
        {
            sW.WriteLine("JOIN #" + chan + " " + pass);
            sW.Flush();
        }

        public void sendMessage(string msg, string chan)
        {
            sW.WriteLine("PRIVMSG #" + chan + " :" + msg);
            sW.Flush();
        }

        public string readMessage()
        {
            return sR.ReadLine();
        }
    }
}
