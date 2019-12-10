using Duality;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Drawing;
using Duality.Resources;
using DualityGambleGame.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Graphics
{
    [RequiredComponent(typeof(Transform))]
    public class PlayerRenderer : Component, ICmpInitializable, ICmpRenderer
    {
        [DontSerialize]
        private GameBoardComponent gameBoardComponent;

        private Transform transform;

        [DontSerialize]
        private ContentRef<Material> playerOneMat;

        [DontSerialize]
        private ContentRef<Material> playerTwoMat;

        [DontSerialize]
        private ContentRef<Material> playerThreeMat;

        [DontSerialize]
        private ContentRef<Material> playerFourMat;

        private List<GameObject> playerList;
        
        public void OnActivate()
        {
            if (DualityApp.ExecEnvironment == DualityApp.ExecutionEnvironment.Editor)
                return;

            this.gameBoardComponent = GameObj.Scene.FindComponent<GameBoardComponent>();
            this.transform = GameObj.GetComponent<Transform>();

            //Preload the game assets
            this.playerOneMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "alienPink").FirstOrDefault();
            this.playerOneMat.EnsureLoaded();
            this.playerTwoMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "alienGreen").FirstOrDefault();
            this.playerTwoMat.EnsureLoaded();
            this.playerThreeMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "alienBeige").FirstOrDefault();
            this.playerThreeMat.EnsureLoaded();
            this.playerFourMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "alienYellow").FirstOrDefault();
            this.playerFourMat.EnsureLoaded();

            playerList = new List<GameObject>();

            //Create the players off screen
            for (int playerNumber = 1; playerNumber <= 4; playerNumber++)
            {
                GameObject player = new GameObject("Player" + playerNumber);               
                Transform playerTransform = new Transform();
                playerTransform.Pos = new Vector3(-2000, -2000, 0); //Create the coin way off screen

                player.AddComponent(playerTransform);

                SpriteRenderer tempCoinSpriteRenderer = new SpriteRenderer();
                tempCoinSpriteRenderer.DepthOffset = -10;

                switch (playerNumber)
                {
                    case 1:
                        tempCoinSpriteRenderer.SharedMaterial = playerOneMat;
                        break;

                    case 2:
                        tempCoinSpriteRenderer.SharedMaterial = playerTwoMat;
                        break;

                    case 3:
                        tempCoinSpriteRenderer.SharedMaterial = playerThreeMat;
                        break;

                    case 4:
                        tempCoinSpriteRenderer.SharedMaterial = playerFourMat;
                        break;
                }

                tempCoinSpriteRenderer.Rect = new Rect(0, 0, 66, 92);

                player.AddComponent(tempCoinSpriteRenderer);
                playerList.Add(player);
                GameObj.Scene.AddObject(player);                
            }
        }

        public void Draw(IDrawDevice device)
        {
            if (DualityApp.ExecEnvironment == DualityApp.ExecutionEnvironment.Editor)
                return;

            //Draw the aliens on the player tiles
            for (int widthIndex = 0; widthIndex < this.gameBoardComponent.GameBoard.Width(); widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < this.gameBoardComponent.GameBoard.Height(); heightIndex++)
                {
                    Player tilePlayer = this.gameBoardComponent.GameBoard.GetTile(widthIndex, heightIndex).Player();

                    if (tilePlayer == null)
                        continue;

                    playerList[tilePlayer.PlayerNumber() - 1].Transform.Pos = new Vector3((-225 + 150 * widthIndex) + 32, (-225 + 150 * heightIndex) + 14, 0);
                }
            }
        }

        public void GetCullingInfo(out CullingInfo info)
        {
            info.Position = this.transform.Pos;
            info.Radius = 250; //TODO: figure out size with tiles and margins
            info.Visibility = VisibilityFlag.All;
        }
        
        public void OnDeactivate()
        {
            foreach(var player in playerList)
            {
                GameObj.Scene.RemoveObject(player);
            }

            playerList = null;
        }
    }
}
