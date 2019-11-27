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

        //TODO: make this better...  Just random for now.
        public void DoAI()
        {
            for(int playerIndex = 2; playerIndex <= 4; playerIndex++)
            {
                if (playerIndex == 2)
                {
                    double seed = RNG.NextDouble();

                    if (seed >= 0.33)
                    {
                        gameBoard.TryMove(new Vector2(0,-1), playerIndex);
                    }
                    else if (seed > 0.33 && seed <= 0.66)
                    {
                        gameBoard.TryMove(new Vector2(1, 0), playerIndex);
                    }
                    else
                    {
                        gameBoard.TryMove(new Vector2(0, 1), playerIndex);
                    }
                }
                else if (playerIndex == 3)
                {
                    double seed = RNG.NextDouble();

                    if (seed >= 0.33)
                    {
                        gameBoard.TryMove(new Vector2(0, -1), playerIndex);
                    }
                    else if (seed > 0.33 && seed <= 0.66)
                    {
                        gameBoard.TryMove(new Vector2(-1, 0), playerIndex);
                    }
                    else
                    {
                        gameBoard.TryMove(new Vector2(0, 1), playerIndex);
                    }
                }
                else if (playerIndex == 4)
                {
                    double seed = RNG.NextDouble();

                    if (seed >= 0.33)
                    {
                        gameBoard.TryMove(new Vector2(-1, 0), playerIndex);
                    }
                    else if (seed > 0.33 && seed <= 0.66)
                    {
                        gameBoard.TryMove(new Vector2(0, -1), playerIndex);
                    }
                    else
                    {
                        gameBoard.TryMove(new Vector2(1, 0), playerIndex);
                    }
                }

            }
        }
    }
}
