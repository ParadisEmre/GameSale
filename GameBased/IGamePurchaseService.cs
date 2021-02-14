using System;
using System.Collections.Generic;
using System.Text;

namespace GameConfiguration
{
    interface IGamePurchaseService
    {
        void Add(PlayerProp player, GameProp game);
        void Remove(PlayerProp player, GameProp game);
        void Update();
    }
}
