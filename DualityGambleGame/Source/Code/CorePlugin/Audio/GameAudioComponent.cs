using Duality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Audio
{
    public class GameAudioComponent : Component, ICmpInitializable
    {
        public void OnActivate()
        {
            //TODO: load up the music and SFX and fade music in
        }

        public void OnDeactivate()
        {
            //Unload things
        }
    }
}
