using GameStoreDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesStoreDemo
{
    class PlayerValidationManager : IPlayerValidationService
    {
        public bool Validation(Player player)  {
            
            if (player.FirstName == "Hamza" && player.LastName == "Yüksel" && player.Id == 1 && player.PlayerTC == "12345" && player.BirthYear == 2002)
            {
                return true;
            }
            else
            {
                return false;            
            } 
        }
        
            
        
    }
}
