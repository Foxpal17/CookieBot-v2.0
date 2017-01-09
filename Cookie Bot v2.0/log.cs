using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cookie_Bot_v2._0
{
    class log
    {
        public static void logg()
        {
            BotLaunch.DiscordClient.MessageReceived += (s, e) =>
            {
                DateTime date = DateTime.Now;
                string text = "[Server:" + e.Server.Name+ "/" + e.Channel.Name +"] " + "[Date:" + date + "] [" + 
                e.User.Name + "] " + e.Message.Text;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.White;
                System.IO.Directory.CreateDirectory("C:\\users\\" + Environment.UserName + "\\Documents\\BotLogs");
                try
                {
                    File.AppendAllText("C:\\Users\\" + Environment.UserName + "\\Documents\\BotLogs\\MessageLog.txt", Environment.NewLine + text);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error logging in MessageLogs");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            };
        }
    }
}
