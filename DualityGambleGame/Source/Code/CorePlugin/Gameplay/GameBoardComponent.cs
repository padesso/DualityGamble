using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Duality;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Drawing;
using Duality.Resources;
using DualityGambleGame.AI;
using DualityGambleGame.State;
using static Duality.Drawing.FormattedText;

namespace DualityGambleGame.Gameplay
{
    [RequiredComponent(typeof(Transform))]
    public class GameBoardComponent : Component, ICmpInitializable, ICmpUpdatable, ICmpRenderer
    {
        [DontSerialize]
        private Canvas canvas = new Canvas();

        [DontSerialize]
        private GameBoard gameBoard;

        [DontSerialize]
        private GameAI gameAI;

        [DontSerialize]
        private TextRenderer debugTextRenderer;

        [DontSerialize]
        private SoundEmitter sfxEmitter;

        private Transform transform;

        private bool debugMode;

        public void OnActivate()
        {
            this.debugTextRenderer = GameObj.Scene.FindComponent<TextRenderer>();
            this.sfxEmitter = GameObj.Scene.FindComponents<SoundEmitter>().Where(e => e.GameObj.Name == "SoundEffects").FirstOrDefault();
            this.transform = GameObj.GetComponent<Transform>();

            this.GameBoard = new GameBoard();
            this.gameAI = new GameAI(this.GameBoard);

            ResetGame();
        }

        private void ResetGame()
        {            
            this.GameBoard.Init();            
            this.gameAI.DoAI();
        }

        public void OnUpdate()
        {
            //Input
            if (StateMachine.CurrentState == StateMachine.GameState.WaitingPlayerInput)
            {
                debugTextRenderer.Text = new FormattedText("Press a direction key to choose a tile.");

                if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Left))
                {
                    if (this.GameBoard.TryMove(new Vector2(-1, 0), 1))
                    {
                        StateMachine.SetGameState(StateMachine.GameState.ShowResults);
                    }
                    else
                    {
                        //TODO: play error sound
                    }
                }
                else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Right))
                {
                    if (this.GameBoard.TryMove(new Vector2(1, 0), 1))
                    {
                        StateMachine.SetGameState(StateMachine.GameState.ShowResults);
                    }
                    else
                    {
                        //TODO: play error sound
                    }
                }
                else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Down))
                {
                    if (this.GameBoard.TryMove(new Vector2(0, 1), 1))
                    {
                        StateMachine.SetGameState(StateMachine.GameState.ShowResults);
                    }
                    else
                    {
                        //TODO: play error sound
                    }
                }
                else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Up))
                {
                    if (this.GameBoard.TryMove(new Vector2(0, -1), 1))
                    {
                        StateMachine.SetGameState(StateMachine.GameState.ShowResults);
                    }
                    else
                    {
                        //TODO: play error sound
                    }
                }
            }
            else if (StateMachine.CurrentState == StateMachine.GameState.ShowResults)
            {
                //TODO: compare moves
                GameTile playerOneSelectedeTile = this.GameBoard.GetPlayerMove(1);
                GameTile playerTwoSelectedTile = this.GameBoard.GetPlayerMove(2);
                GameTile playerThreeSelectedTile = this.GameBoard.GetPlayerMove(3);
                GameTile playerFourSelectedTile = this.GameBoard.GetPlayerMove(4);

                bool playerOneScores = true;
                bool playerTwoScores = true;
                bool playerThreeScores = true;
                bool playerFourScores = true;

                //Check all players if they picked same tile as other players
                if (playerOneSelectedeTile.Equals(playerTwoSelectedTile))
                {                    
                    Debug.WriteLine("Player 1 and 2 picked same tile");
                    playerOneScores = false;
                    playerTwoScores = false;
                }

                if (playerOneSelectedeTile.Equals(playerThreeSelectedTile))
                {
                    Debug.WriteLine("Player 1 and 3 picked same tile");
                    playerOneScores = false;
                    playerThreeScores = false;
                }

                if (playerOneSelectedeTile.Equals(playerFourSelectedTile))
                {
                    Debug.WriteLine("Player 1 and 4 picked same tile");
                    playerOneScores = false;
                    playerFourScores = false;
                }

                if (playerTwoSelectedTile.Equals(playerThreeSelectedTile))
                {
                    Debug.WriteLine("Player 2 and 3 picked same tile");
                    playerTwoScores = false;
                    playerThreeScores = false;
                }

                if (playerTwoSelectedTile.Equals(playerFourSelectedTile))
                {
                    Debug.WriteLine("Player 2 and 4 picked same tile");
                    playerTwoScores = false;
                    playerFourScores = false;
                }

                if (playerThreeSelectedTile.Equals(playerFourSelectedTile))
                {
                    Debug.WriteLine("Player 3 and 4 picked same tile");
                    playerThreeScores = false;
                    playerFourScores = false;
                }

                //Handle scoring
                if (playerOneScores)
                {
                    this.GameBoard.GetPlayer(1).AddCoins(playerOneSelectedeTile.NumCoins());
                    Debug.WriteLine("player 1 score: " + playerOneSelectedeTile.NumCoins().ToString());
                }

                if (playerTwoScores)
                {
                    this.GameBoard.GetPlayer(2).AddCoins(playerTwoSelectedTile.NumCoins());
                    Debug.WriteLine("player 2 score: " + playerTwoSelectedTile.NumCoins().ToString());
                }

                if (playerThreeScores)
                {
                    this.GameBoard.GetPlayer(3).AddCoins(playerThreeSelectedTile.NumCoins());
                    Debug.WriteLine("player 3 score: " + playerThreeSelectedTile.NumCoins().ToString());
                }

                if (playerFourScores)
                {
                    this.GameBoard.GetPlayer(4).AddCoins(playerFourSelectedTile.NumCoins());
                    Debug.WriteLine("player 4 score: " + playerFourSelectedTile.NumCoins().ToString());
                }

                StateMachine.SetGameState(StateMachine.GameState.PlayAgain);
            }
            else if (StateMachine.CurrentState == StateMachine.GameState.PlayAgain)
            {
                this.debugTextRenderer.Text = new FormattedText("Do you want to play again? Press Y to try again.");

                if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Y))
                {
                    ResetGame();
                }
            }
        }

        public void GetCullingInfo(out CullingInfo info)
        {
            info.Position = this.transform.Pos;
            info.Radius = 250; //TODO: figure out size with tiles and margins
            info.Visibility = VisibilityFlag.All;
        }

        public void Draw(IDrawDevice device)
        {
            //Draw the game board...  
            //Vector2 screenCenter = this.ca


            //debug for now
            if (DebugMode)
            {
                // Prepare the Canvas for rendering to the target device
                this.canvas.Begin(device);

                for (int widthIndex = 0; widthIndex < this.GameBoard.Width(); widthIndex++)
                {
                    for (int heightIndex = 0; heightIndex < this.GameBoard.Height(); heightIndex++)
                    {
                        GameTile tile = GameBoard.GetTile(widthIndex, heightIndex);

                        //TODO: modify position based on indices
                        Vector3 pos = new Vector3(
                            this.GameObj.Transform.Pos.X + widthIndex * 128,
                            this.GameObj.Transform.Pos.Y + heightIndex * 128,
                            this.GameObj.Transform.Pos.Z
                            );

                        // Draw tile debug
                        if (tile.Player() == null)
                        {                            
                            canvas.DrawText(new FormattedText("/cffd700FF Coins: " + tile.NumCoins()), pos.X, pos.Y, pos.Z, null, Alignment.TopLeft, true);
                        }
                        else
                        {                            
                            canvas.DrawText(new FormattedText("/c000000FF Player: " + tile.Player().PlayerNumber()), pos.X, pos.Y, pos.Z, null, Alignment.TopLeft, false);
                            canvas.DrawText(new FormattedText("/cFF0000FF Score: " + tile.Player().TotalCoins()), pos.X, pos.Y + 20, pos.Z, null, Alignment.TopLeft, false);
                        }
                    }
                }

                // Finalize rendering with our Canvas
                this.canvas.End();
            }
        }

        public void OnDeactivate()
        {
            //TODO: cleanup
        }


        public bool DebugMode
        {
            get
            {
                return debugMode;
            }

            set
            {
                debugMode = value;
            }
        }

        public GameBoard GameBoard
        {
            get
            {
                return gameBoard;
            }

            private set
            {
                gameBoard = value;
            }
        }
    }
}
