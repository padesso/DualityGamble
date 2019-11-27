using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Gameplay
{
    public class Player
    {
        private bool isPlayerCharacter;
        private int totalCoins = 0;

        public Player(bool isPlayerCharacter)
        {
            this.isPlayerCharacter = isPlayerCharacter;
        }

        public bool IsPlayerCharacter()
        {
            return this.isPlayerCharacter;
        }

        public void AddCoins(int coins)
        {
            totalCoins += coins;
        }
    }
}
