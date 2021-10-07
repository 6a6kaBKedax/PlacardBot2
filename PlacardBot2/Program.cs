using System;

namespace PlacardBot2
{
    using Telegram.Bot;
    using Telegram.Bot.Args;

    class Program
    {
        static private readonly string token = "1988064770:AAGYkUB3fZQiuejtm-zdHSIJ3DkAJHmudbk";

        public static readonly TelegramBotClient Client = new TelegramBotClient(token);

        [Obsolete]
        static void Main(string[] args)
        {
            Client.StartReceiving();
            Client.OnMessage += BotController.OnMessageController;
            Client.StopReceiving();
            Console.ReadKey();
        }       
    }
}
