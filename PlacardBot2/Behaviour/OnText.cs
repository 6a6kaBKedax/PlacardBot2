namespace PlacardBot2.Behaviour
{
    using System.Collections.Generic;
    using Telegram.Bot.Types;

    class OnText
    {
        public static void OnSuicide(Message message) 
        {
            //throw new ArgumentException() { };
            System.IO.FileStream stiker = System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Linked\skull_animated_sticker.gif");
            Sender.SendChatReplaySticker(message, stiker);
        }

        public static void OnFatality(Message message)
        {
            //throw new ArgumentException() { };
            System.IO.FileStream stiker = System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\Photos\Medvedev.jpg");
            Sender.SendChatReplayGIF(message, stiker);
        }

        public static void OnKill(Message message) 
        {
            System.IO.FileStream fileStream = System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\Audio\Летов - Убивать.mp3");
            Sender.SendChatReplayVoiceMessage(message, fileStream);
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

        public static void OnGosling(Message message)
        {
            //throw new ArgumentException() { };
            Sender.SendChatReplaySticker(message, GoslingLogic.DriveReturner());
        }

        public static void OnGIF(Message message) 
        {
            List<System.IO.FileStream> gifs = new List<System.IO.FileStream>();
            gifs.Add(BrigadaLogic.BrigadaReturner());
            gifs.Add(GoslingLogic.DriveReturner());
            System.Random rnd = new System.Random();
            if (!gifs.Count.Equals(0))
            {
                Sender.SendChatReplaySticker(message, gifs[rnd.Next(0, gifs.Count)]);
            }
        }

        public static void OnGIFRND(Message message)
        {
            System.Random rnd = new System.Random();
            if (rnd.Next(12).Equals(5))
            {
                List<System.IO.FileStream> gifs = new List<System.IO.FileStream>();
                gifs.Add(BrigadaLogic.BrigadaReturner());
                gifs.Add(GoslingLogic.DriveReturner());
                if (!gifs.Count.Equals(0))
                {
                    Sender.SendChatReplaySticker(message, gifs[rnd.Next(0, gifs.Count - 1)]);
                }
            }  
        }
    }
}
