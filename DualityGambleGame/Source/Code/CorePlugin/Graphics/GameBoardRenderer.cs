using Duality;
using Duality.Components;
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
