using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Duality;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Drawing;
using DualityGambleGame.AI;
using DualityGambleGame.State;

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

        private Transform transform;

        private bool debugMode;

        public void OnActivate()
        {
            this.debugTextRenderer = GameObj.Scene.FindComponent<TextRenderer>();
            this.transform = GameObj.GetComponent<Transform>();

            this.gameBoard = new GameBoard();
            this.gameBoard.Init();

            this.gameAI = new GameAI(this.gameBoard);
            this.gameAI.DoAI();

            StateMachine.SetGameState(StateMachine.GameState.WaitingPlayerInput);
        }

        public void OnUpdate()
        {
            debugTextRenderer.Text = new FormattedText("Game state: " + StateMachine.CurrentState.ToString());

            //Input
            if (StateMachine.CurrentState == StateMachine.GameState.WaitingPlayerInput)
            {
                if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Left))
                {
                    if (this.gameBoard.TryMove(new Vector2(-1, 0), 1))
                        StateMachine.SetGameState(StateMachine.GameState.ShowResults);
                }
                else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Right))
                {
                    if(this.gameBoard.TryMove(new Vector2(1, 0), 1))
                        StateMachine.SetGameState(StateMachine.GameState.ShowResults);
                }
                else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Down))
                {
                    if(this.gameBoard.TryMove(new Vector2(0, 1), 1))
                        StateMachine.SetGameState(StateMachine.GameState.ShowResults);
                }
                else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Up))
                {
                    if(this.gameBoard.TryMove(new Vector2(0, -1), 1))
                        StateMachine.SetGameState(StateMachine.GameState.ShowResults);
                }                
            }
            else if (StateMachine.CurrentState == StateMachine.GameState.ShowResults)
            {
                //TODO: compare moves, count down and reset
                Debug.WriteLine("player 1 move: " + this.gameBoard.GetPlayerMove(1).NumCoins().ToString());
                Debug.WriteLine("player 2 move: " + this.gameBoard.GetPlayerMove(2).NumCoins().ToString());
                Debug.WriteLine("player 3 move: " + this.gameBoard.GetPlayerMove(3).NumCoins().ToString());
                Debug.WriteLine("player 4 move: " + this.gameBoard.GetPlayerMove(4).NumCoins().ToString());
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
            //Draw the game board...  debug for now

            if (DebugMode)
            {

                // Prepare the Canvas for rendering to the target device
                this.canvas.Begin(device);

                for (int widthIndex = 0; widthIndex < this.gameBoard.Width(); widthIndex++)
                {
                    for (int heightIndex = 0; heightIndex < this.gameBoard.Height(); heightIndex++)
                    {
                        GameTile tile = gameBoard.GetTile(widthIndex, heightIndex);

                        //TODO: modify position based on indices
                        Vector3 pos = new Vector3(
                            this.GameObj.Transform.Pos.X + widthIndex * 128,
                            this.GameObj.Transform.Pos.Y + heightIndex * 128,
                            this.GameObj.Transform.Pos.Z
                            );

                        // Draw tile debug
                        canvas.DrawText("Coins: " + tile.NumCoins(), pos.X, pos.Y, pos.Z);

                        //int playerNumber = tile.Player().PlayerNumber();
                        //canvas.DrawText("Player: " + playerNumber, pos.X, pos.Y + 20, pos.Z);
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
    }
}
