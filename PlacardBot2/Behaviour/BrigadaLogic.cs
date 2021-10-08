namespace PlacardBot2.Behaviour
{
    using System.Collections.Generic;
    using System.IO;
    using Telegram.Bot.Types;

    class BrigadaLogic
    {
        private static List<FileStream> Gifs = new List<FileStream>();
        
        public BrigadaLogic()
        {
            AddInArrayGifs();
        }
        private static void AddInArrayGifs() 
        {
            Gifs.Add(System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Brigada\mp4 (1).gif"));
            Gifs.Add(System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Brigada\mp4 (2).gif"));
            Gifs.Add(System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Brigada\mp4 (3).gif"));
            Gifs.Add(System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Brigada\mp4 (4).gif"));
            Gifs.Add(System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Brigada\mp4 (5).gif"));
            Gifs.Add(System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Brigada\mp4 (6).gif"));
            Gifs.Add(System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Brigada\mp4 (7).gif"));
            Gifs.Add(System.IO.File.OpenRead(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Brigada\mp4.gif"));
        }

        public static void BrigadaRND(Message message) 
        {
            System.Random rnd = new System.Random();

            if (!Gifs.Count.Equals(0) && rnd.Next(0, 12) == 1)
            {
                Sender.SendChatReplayGIF(message, Gifs[rnd.Next(0, Gifs.Count-1)]);
            }
        }
    }
}
