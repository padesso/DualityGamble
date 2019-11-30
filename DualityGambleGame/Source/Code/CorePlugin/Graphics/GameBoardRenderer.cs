using Duality;
using Duality.Components;
using Duality.Components.Renderers;
using Duality.Drawing;
using Duality.Resources;
using DualityGambleGame.Gameplay;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Graphics
{
    [RequiredComponent(typeof(Transform))]
    public class GameBoardRenderer : Component, ICmpInitializable, ICmpRenderer
    {
        //The gameboard to render
        [DontSerialize]
        private GameBoardComponent gameBoardComponent;

        private Transform transform;

        [DontSerialize]
        private ContentRef<Material> tileMat;

        [DontSerialize]
        private ContentRef<Material> coinMat;

        [DontSerialize]
        private GameObject[] coinPool;

        public void OnActivate()
        {
            //Preload the game assets
            this.tileMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "tile").FirstOrDefault();
            this.tileMat.EnsureLoaded();

            this.coinMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "coinGold").FirstOrDefault();
            this.coinMat.EnsureLoaded();

            this.transform = GameObj.GetComponent<Transform>();
            this.gameBoardComponent = GameObj.Scene.FindComponent<GameBoardComponent>();

            //Draw the game board
            for (int widthIndex = 0; widthIndex < this.gameBoardComponent.GameBoard.Width(); widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < this.gameBoardComponent.GameBoard.Height(); heightIndex++)
                {
                    GameObject tempTileGameObject = new GameObject("Tile_" + widthIndex + "_" + heightIndex);
                    Transform tempTileTransform = new Transform();
                    //TODO: make this more flexible/configurable?
                    tempTileTransform.Pos = new Vector3(-225 + 150 * widthIndex, -225 + 150 * heightIndex, 0);

                    tempTileGameObject.AddComponent(tempTileTransform);

                    SpriteRenderer tempTile = new SpriteRenderer();
                    tempTile.DepthOffset = 0;
                    tempTile.SharedMaterial = tileMat;
                    tempTile.Rect = new Rect(0, 0, 128, 128);

                    tempTileGameObject.AddComponent(tempTile);
                    GameObj.Scene.AddObject(tempTileGameObject);
                }
            }

            //Create a pool of coins off the screen - there is only 5 playable tiles in the game.
            coinPool = new GameObject[5 * this.gameBoardComponent.GameBoard.MaxCoinsPerTile()];

            for (int coinIndex = 0; coinIndex < coinPool.Length; coinIndex++)
            {                
                coinPool[coinIndex] = new GameObject("Coin" + "_" + coinIndex);
                Transform tempCoinTransform = new Transform();
                tempCoinTransform.Pos = new Vector3(-225, -225, 0); //Create the coins off camera
                coinPool[coinIndex].AddComponent(tempCoinTransform);

                SpriteRenderer tempCoin = new SpriteRenderer();
                tempCoin.DepthOffset = 10;
                tempCoin.SharedMaterial = coinMat;
                tempCoin.Rect = new Rect(0, 0, 32, 32);

                coinPool[coinIndex].AddComponent(tempCoin);
                GameObj.Scene.AddObject(coinPool[coinIndex]);
            }
        }

        public void Draw(IDrawDevice device)
        {
            //Iterate through the game board and draw the coins
            for (int widthIndex = 0; widthIndex < this.gameBoardComponent.GameBoard.Width(); widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < this.gameBoardComponent.GameBoard.Height(); heightIndex++)
                {
                    int numCoins = this.gameBoardComponent.GameBoard.GetTile(widthIndex, heightIndex).NumCoins();

                    for(int coinIndex = 0; coinIndex < numCoins; coinIndex++)
                    {
                        //GameObject tempCoinGameObject = new GameObject("Coin" + widthIndex + "_" + heightIndex + "_" + coinIndex);
                        //Transform tempCoinTransform = new Transform();
                        ////TODO: make this more flexible/configurable?
                        //tempCoinTransform.Pos = new Vector3(-225 + (150 * widthIndex) + 5 * coinIndex, -225 + 150 * heightIndex, 0);

                        //tempCoinGameObject.AddComponent(tempCoinTransform);

                        //SpriteRenderer tempCoin = new SpriteRenderer();
                        //tempCoin.DepthOffset = -10;
                        //tempCoin.SharedMaterial = coinMat;
                        //tempCoin.Rect = new Rect(0, 0, 36, 36);

                        //tempCoinGameObject.AddComponent(tempCoin);
                        //GameObj.Scene.AddObject(tempCoinGameObject);
                    }                    
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
            //Get rid of the pool of coins
            for (int coinIndex = 0; coinIndex < coinPool.Length; coinIndex++)
            {
                GameObj.Scene.RemoveObject(coinPool[coinIndex]);
            }

            coinPool = null;
        }
    }
}
