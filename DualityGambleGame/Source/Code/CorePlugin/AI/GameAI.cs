using Duality;
using DualityGambleGame.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.AI
{
    public class GameAI
    {
        private Random RNG = new Random();

        private GameBoard gameBoard;

        public GameAI(GameBoard gameBoard)
        {            
            this.gameBoard = gameBoard;
        }

        //TODO: make this better...
        public void DoAI()
        {
            for(int playerIndex = 2; playerIndex < 4; playerIndex++)
            {
                if (playerIndex == 2)
                {
                    if (RNG.NextDouble() >= 0.5)
                    {
                        gameBoard.TryMove(new Vector2(-1,0), playerIndex);
                    }
                    else
                    {
                        gameBoard.TryMove(new Vector2(0, 1), playerIndex);
                    }
                }
                else if (playerIndex == 3)
                {
                    if (RNG.NextDouble() >= 0.5)
                    {
                        gameBoard.TryMove(new Vector2(0, -1), playerIndex);
                    }
                    else
                    {
                        gameBoard.TryMove(new Vector2(1, 0), playerIndex);
                    }
                }
                else if (playerIndex == 4)
                {
                    if (RNG.NextDouble() >= 0.5)
                    {
                        gameBoard.TryMove(new Vector2(-1, 0), playerIndex);
                    }
                    else
                    {
                        gameBoard.TryMove(new Vector2(0, -1), playerIndex);
                    }
                }

            }
        }
    }
}
