using System;
using System.Collections.Generic;
using System.Text;

namespace GameConfiguration
{
    class GameManager : IGamePurchaseService
    {
        public void Add(PlayerProp player,GameProp game)
        {
            Console.WriteLine(game.Name + " is added to " + player.Name + " " + player.Surname + "'s purchase list.");
        }

        public void Remove(PlayerProp player, GameProp game)
        {
            Console.WriteLine(game.Name + " is removed from " + player.Name + " " + player.Surname + "'s purchase list.");
        }

        public void Update()
        {
            Console.WriteLine("Your purchase list is updated.");
        }
    }
}
