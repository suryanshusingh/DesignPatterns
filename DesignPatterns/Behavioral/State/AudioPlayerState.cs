using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    abstract class AudioPlayerState
    {
        public AudioPlayer player;
        public AudioPlayerState(AudioPlayer player)
        {
            this.player = player;
        }
        public abstract void OnPlayPauseButtonClick();
        public abstract void OnNextButtonClick();
        public abstract void OnLockButtonClick();
    }
}
