using GamesStoreDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    class PlayerManager : IPlayerService
    {
        // Eğer bir sınıfın içerisine başka bir sınıfı inherite edeceksen asla newleme aşşağıdaki gibi kullan.
        IPlayerValidationService _playerValidationService;
        
        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            _playerValidationService = playerValidationService;
        }
        public void Add(Player player)
        {
            if (_playerValidationService.Validation(player) == true)
            {
                Console.WriteLine("Player added successfully.");
            }
            else
            {
                Console.WriteLine("This person is not valid.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player updated");
        }
    }
}
