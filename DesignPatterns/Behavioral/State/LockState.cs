using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    class LockState : AudioPlayerState
    {
        public LockState(AudioPlayer player) : base(player)
        {

        }
        public override void OnLockButtonClick()
        {
            Console.WriteLine("Device has been unlocked");
            if (player.IsPlaying)
                player.ChangeState(new PlayState(player));
            else
                player.ChangeState(new PauseState(player));
        }

        public override void OnNextButtonClick()
        {
            Console.WriteLine("Cannot go to next song. Device is locked");
        }

        public override void OnPlayPauseButtonClick()
        {
            Console.WriteLine("Cannot play/pause when locked");
        }
    }
}
