namespace PlacardBot2.Behaviour
{
    using Telegram.Bot.Types;

    class OnText
    {
        public static void OnSuicide(Message message) 
        {
            //throw new ArgumentException() { };
            System.IO.FileStream stiker = System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Linked\skull_animated_sticker.gif");
            Sender.SendChatReplaySticker(message, stiker);
        }

        public static void OnCringeUKR(Message message)
        {
            //throw new ArgumentException() { };
            System.IO.FileStream stiker = System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\Videos\Cringe\ukrcringe.mp4");
            Sender.SendChatReplayVideoMessage(message, stiker);
        }

        public static void OnCringeBG(Message message)
        {
            //throw new ArgumentException() { };
            System.IO.FileStream stiker = System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\Videos\Cringe\bgcringe.MP4");
            Sender.SendChatReplayVideoMessage(message, stiker);
        }

        public static void OnCringeES(Message message)
        {
            //throw new ArgumentException() { };
            System.IO.FileStream stiker = System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\Videos\Cringe\spaincringe.mp4");
            Sender.SendChatReplayVideoMessage(message, stiker);
        }

        public static void OnCringeEN(Message message)
        {
            //throw new ArgumentException() { };
            System.IO.FileStream stiker = System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\Videos\Cringe\EnCringe.mp4");
            Sender.SendChatReplayVideoMessage(message, stiker);
        }
    }
}
