using Cleverbot.Net;
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
            var session = CleverbotSession.NewSession("Her42ecmAOFYJy9r", "urRmT2HszsCQCxUsiBDQ3ZUOG0TZurGH");

            BotLaunch.commands.CreateCommand("cleverbot")
                .Parameter("message", Discord.Commands.ParameterType.Required | Discord.Commands.ParameterType.Unparsed)
                .Alias("cb", "CleverBot")
                .Description("Talk to CleverBot")
                .Do(async (e) =>
                {
                    var cbmessage = e.GetArg("message");
                    await e.Channel.SendMessage(session.Send(cbmessage));
                });
        }
    }
}
