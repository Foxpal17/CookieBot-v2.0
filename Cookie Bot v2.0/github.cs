using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Bot_v2._0
{
    class github
    {
        public static void gh()
        {
            BotLaunch.commands.CreateCommand("Github")
                .Alias("github", "gh")
                .Description("GitHub link")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Here's my GitHub link: https://github.com/Foxpal17/cookiebot-v2.0");
                });
        }
    }
}
