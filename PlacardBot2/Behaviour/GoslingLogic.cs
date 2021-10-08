namespace PlacardBot2.Behaviour
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Telegram.Bot.Types;

    class GoslingLogic
    {
        private static List<string> Gifs = new List<string>();

        public GoslingLogic()
        {
            AddInArrayGifs();
        }
        private static void AddInArrayGifs()
        {
            Gifs.Add(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Drive\1rex.gif");
            Gifs.Add(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Drive\2kIJ.gif");
            Gifs.Add(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Drive\431U.gif");
            Gifs.Add(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Drive\DfIM.gif");
            Gifs.Add(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Drive\HADf.gif");
            Gifs.Add(@"C:\Users\xxxss\source\repos\PlacardBot2\PlacardBot2\Resouses\GIFS\Drive\tumblr_mhmnuuVo801rwpn15o2_500.gif");
        }

        public static void DriveRND(Message message)
        {
            System.Random rnd = new System.Random();

            if (!Gifs.Count.Equals(0) && rnd.Next(0, 12) == 1)
            {
                Sender.SendChatReplaySticker(message, System.IO.File.OpenRead(Gifs[rnd.Next(0, Gifs.Count)]));
            }
        }

        public static System.IO.FileStream DriveReturner()
        {
            System.Random rnd = new System.Random();

            if (!Gifs.Count.Equals(0))
            {
                return System.IO.File.OpenRead(Gifs[rnd.Next(0, Gifs.Count)]);
            }

            return null;
        }
    }
}
