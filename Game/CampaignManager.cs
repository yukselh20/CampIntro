using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    class CampaignManager : ICampaignService
    {
        public void BuyWithDiscount(Game game, Player player)
        {
            Console.WriteLine(game.GameName + " is succesfuly added to your library");
        }
    }
}
