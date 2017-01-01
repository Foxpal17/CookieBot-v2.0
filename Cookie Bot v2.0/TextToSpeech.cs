using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Bot_v2._0
{
    class TextToSpeech
    {
        public static void tts()
        {
            BotLaunch.commands.CreateCommand("tts")
                .Description("Makes a text to speech message")
                .Parameter("text", Discord.Commands.ParameterType.Required | Discord.Commands.ParameterType.Unparsed)
                .Do(async (e) =>
                {
                    string tts = e.GetArg("text");
                    await e.Channel.SendTTSMessage(tts);
                });
        }
    }
}
