using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using System.IO;

namespace Cookie_Bot_v2._0
{
    public class RoastingCommand
    {
        public void RoastCommand()
        {
            Random rnd2;
            string[] roast;
            
            rnd2 = new Random();
            roast = File.ReadAllLines("roasts.json");

            BotLaunch.commands.CreateCommand("roast")
                    .Description("Roasts a chosen user")
                    .Parameter("roasting", ParameterType.Required | ParameterType.Unparsed)
                    .Do(async (e) =>
                    {
                        string whotoroast = e.GetArg("roasting");
                        if (e.Message.IsMentioningMe(true))
                        {
                            await e.Channel.SendMessage("I bet you thought you were funny with that one.");
                        }
                        else
                        {
                            int roast1 = rnd2.Next(roast.Length);
                            string roast2 = roast[roast1];
                            await e.Channel.SendMessage(whotoroast + ", " + roast2);
                        }
             });        
        }
    }
}
