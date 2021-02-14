using System;
using System.Collections.Generic;
using System.Text;

namespace GameConfiguration
{
    class PlayerManager : IPlayerService
    {
        public void Add(PlayerProp player)
        {
            Console.WriteLine(player.Name + " is added.");
        }

        public void Remove(PlayerProp player)
        {
            Console.WriteLine(player.Name + " is removed.");
        }

        public void Update(PlayerProp player)
        {
            Console.WriteLine(player.Name + " is updated.");
        }
    }
}
