
namespace PlacardBot2
{
    using Telegram.Bot.Args;

    class BotController
    {
        public static void OnMessageController(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if (message.Text != null)
            {
                switch (message.Text)
                {
                    case "суецид":
                        
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
