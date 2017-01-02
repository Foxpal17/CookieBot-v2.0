using Discord;
using Discord.Commands;
using Discord.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Bot_v2._0
{
    class AddBotRole
    {
        public static void BotRole()
        {
            BotLaunch.DiscordClient.JoinedServer += (async (s, e) =>
            {
                var role = await e.Server.CreateRole(name: "CookieBot2", permissions: ServerPermissions.All, color: Color.DarkMagenta, isHoisted: false);
                await e.Server.CurrentUser.AddRoles(role);
            });
            BotLaunch.commands.CreateCommand("updatebotrole")
                .Alias("botrole")
                .Description("Updates the bot role")
                .Do(async (e) =>
            {
                var role = await e.Server.CreateRole(name: "CookieBot2", permissions: ServerPermissions.All, color: Color.DarkMagenta, isHoisted: false);
                await e.Server.CurrentUser.AddRoles(role);
            });
        }
    }
}
