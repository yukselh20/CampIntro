using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    interface ICampaignService
    {
        public void BuyWithDiscount(Game game, Player player);
    }
}
