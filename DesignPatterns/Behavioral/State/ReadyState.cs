using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    class ReadyState : AudioPlayerState
    {
        public ReadyState(AudioPlayer player) : base(player)
        {
        }

        public override void OnLockButtonClick()
        {
            Console.WriteLine("Device has been locked");
            player.ChangeState(new LockState(player));
        }

        public override void OnNextButtonClick()
        {
            Console.WriteLine("No song playing so cannot go to next song");
        }

        public override void OnPlayPauseButtonClick()
        {
            Console.WriteLine("Song starts playing");
            player.IsPlaying = true;
            player.ChangeState(new PlayState(player));
;        }
    }
}
