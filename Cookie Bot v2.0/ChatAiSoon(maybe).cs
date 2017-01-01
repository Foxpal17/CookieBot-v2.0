using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Bot_v2._0
{
    class ChatAiSoon_maybe_
    {
        public static void chatAI()
        {
            BotLaunch.DiscordClient.MessageReceived += (async (s, e) =>
            {
                if (e.Message.IsMentioningMe(true))
                {
                    await e.Channel.SendMessage("Why are you even trying to communicate with me?");
                }
                else
                {
                    return;
                }
            });
        }
    }
}
