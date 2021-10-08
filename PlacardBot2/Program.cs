namespace PlacardBot2
{
    using System;
    using Telegram.Bot;

    class Program
    {
        static private string token = "1988064770:AAEwA6eG9x0Ara4JPmbELoSjea-oafTXmR8";

        public static TelegramBotClient Client;

        [Obsolete]
        static void Main(string[] args)
        {
            Client = new TelegramBotClient(token);
            LoadResurces();
            Client.StartReceiving();
            Client.OnMessage += BotController.OnMessageController;
            Console.ReadKey();
            Client.StopReceiving();
        }

        private static void LoadResurces() 
        {
            Behaviour.BrigadaLogic b = new Behaviour.BrigadaLogic();
        }
    }
}
