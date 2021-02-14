using System;
using System.Collections.Generic;
using System.Text;

namespace GameConfiguration
{
    abstract class Income
    {
        public void CampaignSales(PlayerProp player, GameProp game)
        {
            Console.WriteLine(player.Name + player.Surname + "----> You bought " + game.Name + "." + "Price is" + game.Price + "£.");
        }
        public void NormalSales(PlayerProp player, GameProp game)
        {
            Console.WriteLine(player.Name + player.Surname + "----> You bought " + game.Name + "." + "Price is" + game.Price + "£.");
        }
    }
    
}   
