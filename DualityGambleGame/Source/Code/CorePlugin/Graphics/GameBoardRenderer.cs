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

        public void OnActivate()
        {
            //Preload the game assets
            this.tileMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "tile").FirstOrDefault();
            this.tileMat.EnsureLoaded();

            this.transform = GameObj.GetComponent<Transform>();
            this.gameBoardComponent = GameObj.Scene.FindComponent<GameBoardComponent>();

            Debug.WriteLine("Game board renderer init");

            for(int widthIndex = 0; widthIndex < this.gameBoardComponent.GameBoard.Width(); widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < this.gameBoardComponent.GameBoard.Height(); heightIndex++)
                {
                    GameObject tempGameObject = new GameObject("Tile_" + widthIndex + "_" + heightIndex);
                    Transform tempTransform = new Transform();
                    //TODO: make this more flexible/configurable?
                    tempTransform.Pos = new Vector3(-225 + 150 * widthIndex, -225 + 150 * heightIndex, 0);

                    tempGameObject.AddComponent(tempTransform);

                    SpriteRenderer tempTile = new SpriteRenderer();
                    tempTile.SharedMaterial = tileMat;
                    tempTile.Rect = new Rect(0, 0, 128, 128);

                    tempGameObject.AddComponent(tempTile);
                    GameObj.Scene.AddObject(tempGameObject);
                }
            }
        }

        public void Draw(IDrawDevice device)
        {
            //TODO: iterate through the game board and draw the tiles, coins, etc
            
        }

        public void GetCullingInfo(out CullingInfo info)
        {
            info.Position = this.transform.Pos;
            info.Radius = 250; //TODO: figure out size with tiles and margins
            info.Visibility = VisibilityFlag.All;
        }

        public void OnDeactivate()
        {
            //TODO: clean up?
        }
    }
}
