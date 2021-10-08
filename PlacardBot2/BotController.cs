namespace PlacardBot2
{
    using Telegram.Bot.Args;
    using Behaviour;
    class BotController
    {
        public static void OnMessageController(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if (message.Text != null)
            {
                System.Console.WriteLine($"Человечек {message.From} пишет в чат {message.Chat.Username} следующее: {message.Text}");
                switch (message.Text)
                {
                    case "суецид":
                        OnText.OnSuicide(message);
                        break;
                    case "кринге":
                        OnText.OnCringeES(message);
                        break;
                    case "крiнж":
                        OnText.OnCringeUKR(message);
                        break;
                    case "кринж":
                        OnText.OnCringeBG(message);
                        break;
                    case "cringe":
                        OnText.OnCringeEN(message);
                        break;
                    default:
                        BrigadaLogic.BrigadaRND(message);
                        break;
                }
            }
        }
    }
}
