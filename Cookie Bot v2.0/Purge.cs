using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Bot_v2._0
{
    class Purge
    {
        public static void purgecommand()
        {
           BotLaunch.commands.CreateCommand("purge")
          .Description("Purges messages")
          .Parameter("messages11", Discord.Commands.ParameterType.Required)
          .Do(async (e) =>
           {
             Discord.Message[] messagesToDelete;
             string messagesdelet = e.GetArg("messages11");
             messagesToDelete = await e.Channel.DownloadMessages(Convert.ToInt16(messagesdelet));
             await e.Channel.DeleteMessages(messagesToDelete);
             await e.Channel.SendMessage(":information_source: **| Purge of last " + messagesdelet + " messages completed**");
             await e.Channel.SendMessage(":information_source: **| Purged Channel For " + e.User.Name + "**");
           });
        }
    }
}
