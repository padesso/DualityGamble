using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Gameplay
{
    public struct GameTile
    {        
        private int numCoins;
        private Player player;
        private int x;
        private int y;

        public GameTile(int x, int y,int numCoins, Player player)
        {
            this.x = x;
            this.y = y;
            this.numCoins = numCoins;
            this.player = player;
        }

        public int NumCoins()
        {
            return this.numCoins;
        }

        public Player Player()
        {
            return this.player;
        }
    }
}
