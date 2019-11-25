using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Gameplay
{
    public class Player
    {
        private int playerNumber;
        private bool isPlayerCharacter;

        public Player(int playerNumber, bool isPlayerCharacter)
        {
            this.playerNumber = playerNumber;
            this.isPlayerCharacter = isPlayerCharacter;
        }

        public int PlayerNumber()
        {
            return this.playerNumber;
        }

        public bool IsPlayerCharacter()
        {
            return this.isPlayerCharacter;
        }
    }
}
