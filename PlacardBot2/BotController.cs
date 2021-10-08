namespace PlacardBot2
{
    using Telegram.Bot.Args;
    using Behaviour;
    using System;

    class BotController
    {
        public static void OnMessageController(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if (message.Text != null)
            {
                System.Console.WriteLine($"Человечек {message.From} пишет в чат {message.Chat.Id} следующее: {message.Text}");
                switch (message.Text.ToLower())
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
                    case "гифка":
                        OnText.OnGIF(message);
                        break;
                    case "убивать":
                        OnText.OnKill(message);
                        break;
                    case "добить":
                        OnText.OnFatality(message);
                        break;
                    case "гослинг":
                        OnText.OnGosling(message);
                        break;
                    default:
                        OnText.OnGIFRND(message);
                        break;
                }
            }
        }
    }
}
