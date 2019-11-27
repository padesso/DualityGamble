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
        private GameTile[] targetTiles;

        public GameBoard()
        {
            
        }

        public void Init()
        {
            StateMachine.SetGameState(StateMachine.GameState.GeneratingBoard);

            boardArray = new GameTile[WIDTH, HEIGHT];
            targetTiles = new GameTile[4];

            for (int widthIndex = 0; widthIndex < WIDTH; widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < HEIGHT; heightIndex++)
                {
                    //Don't generate coins on the corners where players start
                    if (widthIndex == 1 && heightIndex == 0) //top center
                    {
                        boardArray[widthIndex, heightIndex] = new GameTile(widthIndex, heightIndex, 0, new Player(true, 1));
                        continue;
                    }

                    if (widthIndex == 0 && heightIndex == 1) //left center
                    {
                        boardArray[widthIndex, heightIndex] = new GameTile(widthIndex, heightIndex, 0, new Player(false, 2));
                        continue;
                    }

                    if (widthIndex == WIDTH - 1 && heightIndex == 1) //right center
                    {
                        boardArray[widthIndex, heightIndex] = new GameTile(widthIndex, heightIndex, 0, new Player(false, 3));
                        continue;
                    }

                    if (widthIndex == 1 && heightIndex == HEIGHT - 1) //bottom center
                    {
                        boardArray[widthIndex, heightIndex] = new GameTile(widthIndex, heightIndex, 0, new Player(false, 4));
                        continue;
                    }

                    boardArray[widthIndex, heightIndex] = new GameTile(widthIndex, heightIndex, RNG.Next(MIN_COINS, MAX_COINS + 1), null);
                }
            }

            StateMachine.SetGameState(StateMachine.GameState.WaitingPlayerInput);
        }

        public GameTile GetTile(int x, int y)
        {
            return this.boardArray[x, y];
        }

        public bool TryMove(Vector2 moveDirection, int playerNumber)
        {
            Debug.WriteLine("Attempting move for player : " + playerNumber + " : " + moveDirection.ToString());

            switch(playerNumber)
            {
                case 1:
                    if (moveDirection.Y < 0)
                        return false;

                    targetTiles[0] = this.GetTile(1 + (int)moveDirection.X, 0 + (int)moveDirection.Y);                    
                    break;

                case 2:
                    if (moveDirection.X < 0)
                        return false;

                    targetTiles[1] = this.GetTile(0 + (int)moveDirection.X, 1 + (int)moveDirection.Y);
                    break;

                case 3:
                    if (moveDirection.X < 0)
                        return false;

                    targetTiles[2] = this.GetTile(2 + (int)moveDirection.X, 1 + (int)moveDirection.Y);
                    break;

                case 4:
                    if (moveDirection.Y > 0)
                        return false;

                    targetTiles[3] = this.GetTile(1 + (int)moveDirection.X, 2 + (int)moveDirection.Y);
                    break;

                default:
                    //nothing I guess...
                    break;
            }

            return true;
        }

        public GameTile GetPlayerMove(int playerNumber)
        {
            return targetTiles[playerNumber - 1];
        }

        public Player GetPlayer(int playerNumber)
        {
            switch (playerNumber)
            {
                case 1:
                    return this.GetTile(1, 0).Player();

                case 2:
                    return this.GetTile(0, 1).Player();

                case 3:
                    return this.GetTile(2, 1).Player();

                case 4:
                    return this.GetTile(1, 2).Player();
            }

            return null;
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
