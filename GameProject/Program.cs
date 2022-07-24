using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player()
           { Id = 1,FirstName ="Zeynep",LastName="Kırmacı",NickName="Adsız Ülke",DateOfBirth=2001 };
          
             Player player2 = new Player() 
            { Id=2,FirstName="Sude",LastName="Kırmacı",NickName="Kitty",DateOfBirth=1999};


            Games game1 = new Games()  
            {Id =1, GameName = "Minecraft",Price =200 };

            Games game2 = new Games()
            {Id = 2, GameName = "PUBG", Price = 100 };

            Campaign campaign1 = new Campaign()  
            {Id=1, StartDate = "8 Temmuz", FinishDate = "15 Temmuz", Price = 50  };

            Campaign campaign2 = new Campaign()  
            {Id =2 ,StartDate = "20 Ağustos" , FinishDate = "30 Ağustos", Price = 40 };
           

        
            
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            playerManager.Update(player2);

            Console.WriteLine("*******************************");

            GamesManager gamesManager = new GamesManager();
            gamesManager.Install(game2);
            gamesManager.Buy(game1, player2);
            gamesManager.Buy(game2, player1, campaign2);

            Console.WriteLine("*******************************");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);

        }
    }
}
