using GameStoreDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesStoreDemo
{
    interface IPlayerValidationService
    {
        bool Validation(Player player);
    }
}
