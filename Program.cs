using System;
using System.Collections.Generic;

namespace GameConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerProp player1 = new PlayerProp() { IdNum = 123456, BirthYear = 2002, Name = "Emre", Surname = "Özçatal" };

            GameProp game1 = new GameProp() { Duration = 200, Name = "Left 4 Dead 2", Price = 15, Type = "FPS" };

            CampaignProp campaign1 = new CampaignProp() { Name = "Long Time No See !!", DiscountRate = 30, Duration = 20 };

            PlayerManager playerManager = new PlayerManager();

            GameManager gameManager = new GameManager();

            CampaignManager campaignManager = new CampaignManager();

            playerManager.Add(player1);

            gameManager.Remove(player1, game1);

            campaignManager.Update(campaign1);






        }
    }
}
