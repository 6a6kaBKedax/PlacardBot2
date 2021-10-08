namespace PlacardBot2.Behaviour
{
    using Telegram.Bot.Types;

    class Sender
    {
        async public static void SendChatReplayTextMessage(Message message, string text)
        {
            try
            {
                await Program.Client.SendTextMessageAsync(
                message.Chat.Id,
                text,
                replyToMessageId: message.MessageId
                );
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine("передудос на" + x);
            }

        }

        async public static void SendChatTextMessage(Message message, string text)
        {
            try
            {
                await Program.Client.SendTextMessageAsync(
                message.Chat.Id,
                text
                );
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine("передудос на" + x);
            }
        }

        async public static void SendChatReplayGIF(Message message, System.IO.FileStream gif)
        {
            try
            {
                await Program.Client.SendPhotoAsync(
                message.Chat.Id,
                gif,
                replyToMessageId: message.MessageId
                );
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine("передудос на" + x);
            }
        }

        async public static void SendChatReplaySticker(Message message, System.IO.FileStream stiker) 
        {
            try
            {
                await Program.Client.SendStickerAsync(
                message.Chat.Id,
                sticker: stiker,
                replyToMessageId: message.MessageId
                );
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine("передудос на" + x);
            }
        }

        async public static void SendChatReplayVideoMessage(Message message, System.IO.FileStream video)
        {
            try
            {
                await Program.Client.SendVideoNoteAsync(
                 chatId: message.Chat.Id,
                 videoNote: video,
                 replyToMessageId: message.MessageId
                );
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine("передудос на" + x);
            }
        }

        async public static void SendChatReplayVoiceMessage(Message message, System.IO.FileStream voice)
        {
            try
            {
                await Program.Client.SendVoiceAsync(
                 chatId: message.Chat.Id,
                 voice: voice,
                 replyToMessageId: message.MessageId
                );
            }
            catch (System.Exception x)
            {
                System.Console.WriteLine("передудос на" + x);
            }
        }
    }
}
