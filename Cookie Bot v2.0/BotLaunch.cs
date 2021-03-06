﻿using System;
using Discord;
using Discord.Commands;
using Discord.API;
using Discord.Modules;
using Discord.Commands.Permissions.Levels;
using System.IO;

namespace Cookie_Bot_v2._0
{
    public class BotLaunch
    {
        public static DiscordClient DiscordClient;
        public static CommandService commands;

        public BotLaunch()
        {

            DiscordClient = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Debug;
                x.LogHandler = Log;
            });

            DiscordClient.UsingCommands(x =>
            {
                x.AllowMentionPrefix = false;
                x.PrefixChar = '>';
                x.HelpMode = HelpMode.Public;
                x.ExecuteHandler = OnCommandExecuted;
            });

            commands = DiscordClient.GetService<CommandService>();

            testcommand.testingcommand();
            RoastingCommand roast = new RoastingCommand();
            roast.RoastCommand();
            Shutdown.ShutdownCommand();
            TextToSpeech.tts();
            github.gh();
            kekpepe.kek();
            Purge.purgecommand();
            ChatAiSoon_maybe_.chatAI();
            log.logg();
            

            commands.CreateCommand("Test")
               .Description("Hello World!")
               .Do(async (e) =>
                  {
                     await e.Channel.SendMessage("Hello, World!");
                  });

            DiscordClient.ExecuteAndWait(async () =>
            {              
                    try
                    {
                    await DiscordClient.Connect("MjMzODI4NjQzNDU1ODkzNTA0.CtwKIA.2dzydfK32P74pj4k_3eZuaaX-V0", TokenType.Bot);
                    Game g = new Game("With chat logs", GameType.Default, null);
                        DiscordClient.SetGame(g);
                    }
                    catch
                    {
                        Console.WriteLine($"[ERROR] Unable to connect to Discord.");
                    }            
            });

        }

        private void OnCommandExecuted(object sender, CommandEventArgs e)
        {
            Console.WriteLine("Command", $"{e.Command.Text} ({e.User.Name})");
        }
        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string text = ($"[{e.Severity}] [{e.Source}] [{e.Message}]");
            Console.WriteLine(text);
            System.IO.Directory.CreateDirectory("C:\\users\\" + Environment.UserName + "\\Documents\\BotLogs");
            try
            {
                File.AppendAllText("C:\\Users\\" + Environment.UserName + "\\Documents\\BotLogs\\DebugLog.txt", Environment.NewLine + text);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error logging in BotLogs");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
