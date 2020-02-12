using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    class PlayState : AudioPlayerState
    {
        public PlayState(AudioPlayer player) : base(player)
        {

        }
        public override void OnLockButtonClick()
        {
            Console.WriteLine("Device has been Locked!!");
            player.ChangeState(new LockState(player));
        }

        public override void OnNextButtonClick()
        {
            Console.WriteLine("Playing next song");
        }

        public override void OnPlayPauseButtonClick()
        {
            Console.WriteLine("Song has been paused");
            player.IsPlaying = false;
            player.ChangeState(new PauseState(player));
        }
    }
}
