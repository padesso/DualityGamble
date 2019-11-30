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
    public class GameBoardRenderer : Component, ICmpInitializable, ICmpUpdatable
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
        private List<GameObject> boardTileList = new List<GameObject>();

        [DontSerialize]
        private List<GameObject> coinPoolList = new List<GameObject>();

        public void OnActivate()
        {
            //Preload the game assets
            this.tileMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "tile").FirstOrDefault();
            this.tileMat.EnsureLoaded();

            this.coinMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "coinGold").FirstOrDefault();
            this.coinMat.EnsureLoaded();

            this.transform = GameObj.GetComponent<Transform>();
            this.gameBoardComponent = GameObj.Scene.FindComponent<GameBoardComponent>();

            //Setup the game board
            for (int widthIndex = 0; widthIndex < this.gameBoardComponent.GameBoard.Width(); widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < this.gameBoardComponent.GameBoard.Height(); heightIndex++)
                {
                    GameObject tempTileGameObject = new GameObject("Tile_" + widthIndex + "_" + heightIndex);
                    Transform tempTileTransform = new Transform();
                    //TODO: make this more flexible/configurable?
                    tempTileTransform.Pos = new Vector3(-225 + 150 * widthIndex, -225 + 150 * heightIndex, 0);

                    tempTileGameObject.AddComponent(tempTileTransform);

                    SpriteRenderer tempTileSpriteRenderer = new SpriteRenderer();
                    tempTileSpriteRenderer.DepthOffset = 0;
                    tempTileSpriteRenderer.SharedMaterial = tileMat;
                    tempTileSpriteRenderer.Rect = new Rect(0, 0, 128, 128);

                    tempTileGameObject.AddComponent(tempTileSpriteRenderer);
                    GameObj.Scene.AddObject(tempTileGameObject);
                    boardTileList.Add(tempTileGameObject);

                    //Create the coin pool - only have 5 non-player tiles currently.  Maybe make this more generic down the road.
                    for (int coinIndex = 0; coinIndex < this.gameBoardComponent.GameBoard.MaxCoinsPerTile(); coinIndex++)
                    {
                        GameObject tempCoinGameObject = new GameObject("Coin" + "_" + widthIndex + "_" + heightIndex + "_" + coinIndex);
                        Transform tempCoinTransform = new Transform();
                        tempCoinTransform.Pos = new Vector3(-2000, -2000, 0); //Create the coin way off screen

                        tempCoinGameObject.AddComponent(tempCoinTransform);

                        SpriteRenderer tempCoinSpriteRenderer = new SpriteRenderer();
                        tempCoinSpriteRenderer.DepthOffset = -10;
                        tempCoinSpriteRenderer.SharedMaterial = coinMat;
                        tempCoinSpriteRenderer.Rect = new Rect(0, 0, 64, 64);

                        tempCoinGameObject.AddComponent(tempCoinSpriteRenderer);
                        GameObj.Scene.AddObject(tempCoinGameObject);
                        coinPoolList.Add(tempCoinGameObject);
                    }
                }
            }   
        }

        public void OnUpdate()
        {
            //Draw from the coin pool and put them in the right place
            for (int widthIndex = 0; widthIndex < this.gameBoardComponent.GameBoard.Width(); widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < this.gameBoardComponent.GameBoard.Height(); heightIndex++)
                {                    
                    var tileCoins = coinPoolList.Where(c => c.Name.Contains("Coin" + "_" + widthIndex + "_" + heightIndex));
                    int numTileCoins = this.gameBoardComponent.GameBoard.GetTile(widthIndex, heightIndex).NumCoins();

                    if (numTileCoins == 0)
                        continue;

                    int tileCoinIndex = 0;

                    foreach(var tileCoin in tileCoins)
                    {
                        //break out if we've drawn enough coins from the pool for this tile
                        if (tileCoinIndex >= numTileCoins)
                            continue;

                        //TODO: spread this out so it displays better
                        tileCoin.Transform.Pos = new Vector3((-225 + 150 * widthIndex) + 10 * tileCoinIndex, -225 + 150 * heightIndex, 0);

                        tileCoinIndex++;
                    }

                    Debug.WriteLine("Wait");
                }
            }
        }

        public void OnDeactivate()
        {
            //Clean up tiles
            foreach(var tile in boardTileList)
            {
                GameObj.Scene.RemoveObject(tile);
            }

            //Clean up coins
            foreach(var coin in coinPoolList)
            {
                GameObj.Scene.RemoveObject(coin);
            }
        }
    }
}
