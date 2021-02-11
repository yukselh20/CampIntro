using GameStoreDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesStoreDemo
{
    interface IGameService
    {
        void Download(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
