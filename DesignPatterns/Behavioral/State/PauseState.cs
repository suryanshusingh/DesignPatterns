using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    class PauseState : AudioPlayerState
    {
        public PauseState(AudioPlayer player) : base(player)
        {

        }
        public override void OnLockButtonClick()
        {
            Console.WriteLine("Device has been Locked!!");
            player.ChangeState(new LockState(player));
        }

        public override void OnNextButtonClick()
        {
            Console.WriteLine("Cannot change song");
        }

        public override void OnPlayPauseButtonClick()
        {
            Console.WriteLine("Song has been resumed");
            player.IsPlaying = true;
            player.ChangeState(new PlayState(player));
        }
    }
}
