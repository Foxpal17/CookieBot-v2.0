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
        Random rnd2;
        string[] roast;

        public void roasting1()
        {
            rnd2 = new Random();
            roast = File.ReadAllLines("roasts.txt");
        }

        public void RoastCommand()
        {
                BotLaunch.commands.CreateCommand("roast")
                    .Description("Roasts a chosen user")
                    .Parameter("roasting", ParameterType.Required)
                    .Do(async (e) =>
                    {
                        /*
                        string whotoroast = e.GetArg("roasting");

                        int roast1 = rnd2.Next(roast.Length);
                        string roast2 = roast[roast1];
                        await e.Channel.SendMessage(whotoroast + ", " + roast2);
                        */
                        await e.Channel.SendMessage(":warning: **| Don't worry, " + e.User.Name + ", this command will be finished soon.**");
             });        
        }
    }
}
