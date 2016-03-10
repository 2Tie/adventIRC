using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace adventIRC
{
    class Program
    {
        static ConfigData configData;

        static void Main(string[] args)
        {
            loadConfig();

            IRC irc = new IRC(configData.server, configData.port, configData.name);
            bool connected = false;
            
            while(true)
            {
                string message = irc.readMessage();
                if (message.Contains("PING") && connected == false)
                {
                    connected = true;
                    for (int i = 0; i < configData.chans.Count; i++)
                    {
                        irc.joinRoom(configData.chans[i], configData.chanPass[i]);
                    }
                }
                if (connected == true)
                {
                    //handle bot logic!

                    //handle messages
                    if (message.Contains("PRIVMSG"))
                    {
                        string chan = message.Substring(message.IndexOf("PRIVMSG") + 9, message.Length - message.IndexOf(":", message.IndexOf("PRIVMSG") + 9) + 1);
                        string msgContent = message.Substring(message.IndexOf(":", message.IndexOf(chan)) + 1);

                        if (chan == configData.chans[0])//if message is in the primary channel, check for commands!
                        {
                            if (msgContent == ".test")
                                irc.sendMessage("testing!", chan);
                        }
                    }
                }
            }
        }

        public static void loadConfig()
        {
            StreamReader reader = new StreamReader(File.OpenRead("config.ini"));
            configData = new ConfigData();

            configData.server = reader.ReadLine();
            configData.port = Convert.ToInt32(reader.ReadLine());
            configData.name = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string chanTemp = reader.ReadLine();
                if (chanTemp.Contains(":"))
                {
                    configData.chans.Add(chanTemp.Substring(0, chanTemp.IndexOf(":")));
                    configData.chanPass.Add(chanTemp.Substring(chanTemp.IndexOf(":") + 1));
                }
                else
                {
                    configData.chans.Add(chanTemp);
                    configData.chanPass.Add("");
                }
            }
        }
    }
}
