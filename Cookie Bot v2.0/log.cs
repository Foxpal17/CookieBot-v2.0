using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Bot_v2._0
{
    class log
    {
        public static void logg()
        {
            BotLaunch.DiscordClient.MessageReceived += (s, e) =>
            {
                string text = e.Message.Text;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[{e.Server.Name}) [{e.User.Name}] [{text}]");
                Console.ForegroundColor = ConsoleColor.White;
            };
        }
    }
}
