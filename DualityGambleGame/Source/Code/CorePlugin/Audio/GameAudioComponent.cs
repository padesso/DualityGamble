using Duality;
using Duality.Audio;
using Duality.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DualityGambleGame.Audio
{
    public class GameAudioComponent : Component, ICmpInitializable
    {
        private ContentRef<Sound> backgroundMusic = null;
        private SoundInstance backgroundMusicInstance = null;

        public void OnActivate()
        {
            if (DualityApp.ExecEnvironment == DualityApp.ExecutionEnvironment.Editor)
                return;

            //TODO: load up the music and SFX and fade music in

            StartBackgroundMusic();
        }

        private void StartBackgroundMusic()
        {
            // Grab a reference to the Sound resource (our music loop)
            this.backgroundMusic = ContentProvider.RequestContent<Sound>(@"Data\Audio\Music\BackgroundMusic.Sound.Res");

            // Start playing                      
            this.backgroundMusicInstance =  DualityApp.Sound.PlaySound(this.backgroundMusic);
            this.backgroundMusicInstance.BeginFadeIn(5f);

            // Set the Looped property to true as we want the music to loop
            this.backgroundMusicInstance.Looped = true;
        }

        public void OnDeactivate()
        {
            //Unload things
            this.backgroundMusic = null;
            this.backgroundMusicInstance = null;
        }
    }
}
