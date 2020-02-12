using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    class AudioPlayer
    {
        private AudioPlayerState state;
        public bool IsPlaying { get; set; }

        public AudioPlayer()
        {
            this.state = new ReadyState(this);
        }

        public void ChangeState(AudioPlayerState newState)
        {
            this.state = newState;
        }

        public void OnPlayPauseButtonClick()
        {
            this.state.OnPlayPauseButtonClick();
        }
        public void OnNextButtonClick()
        {
            this.state.OnNextButtonClick();
        }
        public void OnLockButtonClick()
        {
            this.state.OnLockButtonClick();
        }


    }
}
