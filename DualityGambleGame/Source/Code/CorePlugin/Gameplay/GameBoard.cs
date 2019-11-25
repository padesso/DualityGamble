using Duality;
using DualityGambleGame.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Gameplay
{
    public class GameBoard
    {
        private Random RNG = new Random();

        private const int MIN_COINS = 1;
        private const int MAX_COINS = 9;

        private const int WIDTH = 3;
        private const int HEIGHT = 3;

        private GameTile[,] boardArray;

        public GameBoard()
        {
            boardArray = new GameTile[WIDTH,HEIGHT];

            for(int widthIndex = 0; widthIndex < WIDTH; widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < HEIGHT; heightIndex++)
                {
                    //Don't generate coins on the corners where players start
                    if (widthIndex == 0 && heightIndex == 0)
                    {
                        boardArray[widthIndex, heightIndex] = new GameTile(0, new Player(1, true));
                        continue;
                    }

                    if (widthIndex == WIDTH -1 && heightIndex == 0)
                    {
                        boardArray[widthIndex, heightIndex] = new GameTile(0, new Player(2, false));
                        continue;
                    }

                    if (widthIndex == 0 && heightIndex == HEIGHT - 1)
                    {
                        boardArray[widthIndex, heightIndex] = new GameTile(0, new Player(3, false));
                        continue;
                    }

                    if (widthIndex == WIDTH - 1 && heightIndex == HEIGHT - 1)
                    {
                        boardArray[widthIndex, heightIndex] = new GameTile(0, new Player(4, false));
                        continue;
                    }

                    boardArray[widthIndex, heightIndex] = new GameTile(RNG.Next(MIN_COINS, MAX_COINS + 1), new Player(0, false));
                }
            }
        }

        public GameTile GetTile(int x, int y)
        {
            return this.boardArray[x, y];
        }

        public void TryMove(Vector2 vector2, int playerNumber)
        {
            Debug.WriteLine("Attempting move for player : " + playerNumber + " : " + vector2.ToString());
        }

        public int Width()
        {
            return WIDTH;
        }

        public int Height()
        {
            return HEIGHT;
        }
    }
}
