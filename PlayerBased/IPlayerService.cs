using System;
using System.Collections.Generic;
using System.Text;

namespace GameConfiguration
{
    interface IPlayerService
    {
        void Add(PlayerProp player);
        void Remove(PlayerProp player);
        void Update(PlayerProp player);
    }
}   
    
