using Unity.VisualScripting;
using UnityEngine;

namespace anatomy.levelone
{
    public class levelManager: MonoBehaviour
    {
        public anatomySettings settings;
        public completionSettings completionSettings;


        public void startSim()
        {
            settings.isStarted = true;
            settings.score = 0;
        }

        /// <summary>
        /// after reset button is pressed
        /// need to set everything to previous state
        /// </summary>
        public void resetEverything()
        {
            settings.isStarted = false;
            settings.difficulty = difficulty.EASY;
            settings.timerRunning = false;
            settings.score = 0;
            settings.timer = 300;
            settings.timerReduction = 0;
            settings.errors = 0;
            settings.retries += 1;
            completionSettings.activeStats = false;
            resetCompletionStatus();           
        }

        public void exitButtonPressed()
        {
            resetEverything();
            settings.retries = 0;
            settings.errors = 0;
        }

        public void resetCompletionStatus()
        {
            for(int i = 0; i < 8; i++)
            {
                completionSettings.state[i] = completionSettings.status.DEFAULT;
            }
        }
        
    }


}