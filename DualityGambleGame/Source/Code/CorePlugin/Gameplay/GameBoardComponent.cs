using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Duality;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Drawing;
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

        Transform transform;

        private bool debugMode;

        public void OnActivate()
        {
            this.transform = GameObj.GetComponent<Transform>();
            this.gameBoard = new GameBoard();

            StateMachine.SetGameState(StateMachine.GameState.WaitingInput);
        }

        public void OnUpdate()
        {
            //Input
            if(DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Left))
            {
                TryMove(new Vector2(-1,0));
            }
            else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Right))
            {
                TryMove(new Vector2(1, 0));
            }
            else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Down))
            {
                TryMove(new Vector2(0, 1));
            }
            else if (DualityApp.Keyboard.KeyReleased(Duality.Input.Key.Up))
            {
                TryMove(new Vector2(0, -1));
            }
        }

        private void TryMove(Vector2 vector2)
        {
            if (StateMachine.CurrentState == StateMachine.GameState.WaitingInput)
            {
                Debug.WriteLine("Pressed: " + vector2.ToString());
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

                        int playerNumber = tile.Player().PlayerNumber();
                        canvas.DrawText("Player: " + playerNumber, pos.X, pos.Y + 20, pos.Z);
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
