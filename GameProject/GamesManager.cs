using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamesManager : IGamesService
    {

        List<Games> GamesList;
        public GamesManager()
        {
            GamesList = new List<Games>();
        }

      
        public void Install(Games game)
        {
            GamesList.Add(game);
            Console.WriteLine(game.GameName + " " + "Yükleniyor...");
        }

        public void Remove(Games game)
        {
            GamesList.Add(game);
            Console.WriteLine(game.GameName +"  "+  " Silindi");
        }

        public void Update(Games game)
        {
            Console.WriteLine("Güncellendi");
        }

        public void Buy(Games game, Player player)
        {
            Console.WriteLine(player.FirstName + " " + game.GameName+ " "+ "Oyununu" + " " + game.Price + "TL'ye Satın Alabilirsin");
        }

        public void Buy(Games game, Player player, Campaign campaign)
        {
            Console.WriteLine(player.FirstName + " " + "Büyük Kampanya Geldi");
            Console.WriteLine("------------------------------");
            Console.WriteLine(game.GameName +" "+ "Şimdi" + " " + campaign.Price + " "+ " TL Hemen Satın Al" );
        }
    }
}
