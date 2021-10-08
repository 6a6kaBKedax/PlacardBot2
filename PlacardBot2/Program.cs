namespace PlacardBot2
{
    using System;
    using Telegram.Bot;

    class Program : Resouses.Token
    { 
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
            Behaviour.GoslingLogic g = new Behaviour.GoslingLogic();
        }
    }
}
