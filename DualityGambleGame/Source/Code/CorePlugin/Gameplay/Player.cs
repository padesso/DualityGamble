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
        private int playerNumber;

        public Player(bool isPlayerCharacter, int playerNumber)
        {
            this.isPlayerCharacter = isPlayerCharacter;
            this.playerNumber = playerNumber;
        }

        public bool IsPlayerCharacter()
        {
            return this.isPlayerCharacter;
        }

        public void AddCoins(int coins)
        {
            totalCoins += coins;
        }

        public int TotalCoins()
        {
            return this.totalCoins;
        }

        public int PlayerNumber()
        {
            return this.playerNumber;
        }
    }
}
