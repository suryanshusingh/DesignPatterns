using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    class StateClient
    {
        public static void StateDPStartup()
        {
            var audioPlayer = new AudioPlayer();
            audioPlayer.OnPlayPauseButtonClick();
            audioPlayer.OnNextButtonClick();
            audioPlayer.OnLockButtonClick();
            audioPlayer.OnNextButtonClick();
            audioPlayer.OnPlayPauseButtonClick();
            audioPlayer.OnLockButtonClick();
            audioPlayer.OnNextButtonClick();
            audioPlayer.OnPlayPauseButtonClick();
            audioPlayer.OnNextButtonClick();
            audioPlayer.OnPlayPauseButtonClick();
            audioPlayer.OnNextButtonClick();
 

            Console.ReadKey();
        }
    }
}
