
namespace PlacardBot2.Behaviour
{
    using Telegram.Bot.Args;

    class Sender
    {
        async public static void SendChatReplayTextMessage(MessageEventArgs message, string text)
        {
            try
            {
                await Program.Client.SendTextMessageAsync(
                message.Message.Chat.Id,
                text,
                replyToMessageId: message.Message.MessageId
                );
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine("передудос на" + x);
            }

        }
        async public static void SendChatTextMessage(MessageEventArgs message, string text)
        {
            try
            {
                await Program.Client.SendTextMessageAsync(
                message.Message.Chat.Id,
                text
                );
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine("передудос на" + x);
            }
        }
    }
}
