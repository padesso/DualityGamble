using Duality;
using Duality.Drawing;
using Duality.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Gameplay
{
    public class PlayerRenderer : Component, ICmpInitializable, ICmpRenderer
    {
        [DontSerialize]
        private GameBoardComponent gameBoardComponent;

        [DontSerialize]
        private ContentRef<Material> playerOneMat;

        [DontSerialize]
        private ContentRef<Material> playerTwoMat;

        [DontSerialize]
        private ContentRef<Material> playerThreeMat;

        [DontSerialize]
        private ContentRef<Material> playerFourMat;

        public void OnActivate()
        {
            this.gameBoardComponent = GameObj.Scene.FindComponent<GameBoardComponent>();

            //Preload the game assets
            this.playerOneMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "alienPink").FirstOrDefault();
            this.playerOneMat.EnsureLoaded();

            //Preload the game assets
            this.playerTwoMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "alienGreen").FirstOrDefault();
            this.playerTwoMat.EnsureLoaded();

            //Preload the game assets
            this.playerThreeMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "alienBeige").FirstOrDefault();
            this.playerThreeMat.EnsureLoaded();

            //Preload the game assets
            this.playerFourMat = ContentProvider.GetAvailableContent<Material>().Where(c => c.Name == "alienYellow").FirstOrDefault();
            this.playerFourMat.EnsureLoaded();
        }

        public void Draw(IDrawDevice device)
        {
            throw new NotImplementedException();
        }

        public void GetCullingInfo(out CullingInfo info)
        {
            throw new NotImplementedException();
        }
        
        public void OnDeactivate()
        {
            throw new NotImplementedException();
        }
    }
}
