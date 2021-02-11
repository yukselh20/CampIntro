using GameStoreDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesStoreDemo
{
    class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " is successfully deleted from your computer");
        }

        public void Download(Game game)
        {
            Console.WriteLine(game.GameName + " is downloading.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " is updating.");
        }
    }
}
