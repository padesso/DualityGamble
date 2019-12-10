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

        private ContentRef<Sound> bumpSFX = null;

        private ContentRef<Sound> coinsSFX = null;

        private ContentRef<Sound> noCoinsSFX = null;

        public enum SFX
        {
            Bump,
            Coins,
            NoCoins
        }

        public void OnActivate()
        {
            if (DualityApp.ExecEnvironment == DualityApp.ExecutionEnvironment.Editor)
                return;

            //load up the music and SFX and fade music in
            this.bumpSFX = ContentProvider.RequestContent<Sound>(@"Data\Audio\SFX\bump.Sound.Res");
            this.bumpSFX.EnsureLoaded();

            this.coinsSFX = ContentProvider.RequestContent<Sound>(@"Data\Audio\SFX\GetCoins.Sound.Res");
            this.coinsSFX.EnsureLoaded();

            this.noCoinsSFX = ContentProvider.RequestContent<Sound>(@"Data\Audio\SFX\NoCoins.Sound.Res");
            this.noCoinsSFX.EnsureLoaded();

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

        public void PlaySFX(SFX sfxName)
        {
            switch(sfxName)
            {
                case SFX.Bump:
                    DualityApp.Sound.PlaySound(this.bumpSFX);
                    break;

                case SFX.Coins:
                    DualityApp.Sound.PlaySound(this.coinsSFX);
                    break;

                case SFX.NoCoins:
                    DualityApp.Sound.PlaySound(this.noCoinsSFX);
                    break;
            }
        }

        public void OnDeactivate()
        {
            //Unload things
            this.backgroundMusic = null;
            this.backgroundMusicInstance = null;
        }
    }
}
