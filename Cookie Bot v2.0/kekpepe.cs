using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Bot_v2._0
{
    class kekpepe
    {
        public static void kek()
        {
            BotLaunch.commands.CreateCommand("kekpepe")
                .Alias("kek")
                .Description("kekerino")
                .Do(async (e) =>
                {
                    await e.Channel.SendFile("Items/kekpepe.jpg");
                });
        }
    }
}
