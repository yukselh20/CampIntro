using GamesStoreDemo;
using System;

namespace GameStoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player() {Id = 1, FirstName = "Hamza", LastName = "Yüksel", BirthYear = 2002, PlayerTC = "12345"  };

            PlayerManager playerManager = new PlayerManager(new PlayerValidationManager());
            playerManager.Add(player);
            playerManager.Delete(player);
            playerManager.Update(player);

            Game game = new Game() {GameName = "Resident Evil", GameCategory = "Horror" , GameCost = 500, GameRate = 8.7};

            GameManager gameManager = new GameManager();
            gameManager.Download(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            Campaigns campaign = new Campaigns() {CampaignName = "Discount for students", NumberOfCampaigns = 500, CampaignLastDate = "20.01.2022", DiscountAmount = "%50" };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.BuyWithDiscount(game, player);
            
        }
    }
}
