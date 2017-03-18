using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;

namespace Saber
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run(args).GetAwaiter().GetResult();
        }
        public async Task Run(string[] args)
        {
            DiscordClient client = new DiscordClient(new DiscordConfig()
            {
                Token = File.ReadAllText("token.txt", Encoding.ASCII),
                TokenType = TokenType.Bot,
                DiscordBranch = Branch.Stable,
                LogLevel = LogLevel.Debug,
                UseInternalLogHandler = true,
                AutoReconnect = true
            });

            await client.Connect();
            DiscordDMChannel channel = await client.CreateDM(53011839067361280);

            DiscordMessage dm = await client.SendMessage(channel, "Hi Master!");
            Console.ReadLine();
        }
    }
}
