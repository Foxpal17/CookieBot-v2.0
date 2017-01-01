using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace Cookie_Bot_v2._0
{
    class testcommand
    {
        public static void testingcommand()
        {
          BotLaunch.commands.CreateCommand("Test2")
          .Description("Checks if multi-class commands are working")
          .Do(async (e) =>
             {
               await e.Channel.SendMessage("Ye, multi-class commands are working fam.");
             });
        }
    }
}
