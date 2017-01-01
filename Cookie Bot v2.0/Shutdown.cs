using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cookie_Bot_v2._0
{
    class Shutdown
    {
        public static void ShutdownCommand()
        {
            BotLaunch.commands.CreateCommand("shutdown")
                .Description("Shuts down the bot")
                .Do(async (e) =>
                {
                    ushort owner = (Convert.ToUInt16("6207"));
                    if (e.User.Discriminator != owner)
                    {
                        await e.Channel.SendMessage(":negative_squared_cross_mark: **| You lack the permissions to run this command.**");
                    }
                    else
                    {
                        await e.Channel.SendMessage("```Markdown" + Environment.NewLine + "#Shutting Down```");
                        await e.Channel.SendMessage("```Markdown" + Environment.NewLine + "#Goodbye!```");
                        Thread.Sleep(1000);
                        await BotLaunch.DiscordClient.Disconnect();
                    }
                });
        }
    }
}
