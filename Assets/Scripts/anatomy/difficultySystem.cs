using System.Threading;
using UnityEngine;
using TMPro;

namespace anatomy.levelone
{
    public class difficultySystem : MonoBehaviour
    {
        public anatomySettings settings;

        public TextMeshProUGUI[] usageOrgans = new TextMeshProUGUI[8];
        public TextMeshProUGUI[] organNames = new TextMeshProUGUI[8];


        public void easyLevel()
        {
            if (!settings.isStarted)
            {
                settings.difficulty = difficulty.EASY;
                settings.timer = 300.0f;
                settings.timerReduction = 1.0f;
                disableInstructions(true);
                disableOrganName(true);
            }
           
        }

        public void normalLevel()
        {
            if (!settings.isStarted)
            {
                settings.difficulty = difficulty.NORMAL;
                settings.timer = 240.0f;
                settings.timerReduction = 2.0f;
                disableInstructions(false);
                disableOrganName(true);
            }
        }

        public void hardLevel()
        {
            
              if (!settings.isStarted)
              {
                disableOrganName(false);
                disableInstructions(true);
                settings.difficulty = difficulty.HARD;
                settings.timer = 120.0f;
                settings.timerReduction = 3.5f;
              }
        }

        public void disableOrganName(bool value)
        {
            foreach(TextMeshProUGUI content in organNames)
            {
                content.transform.GetComponent<TextMeshProUGUI>().enabled = value;
            }
        }

        public void disableInstructions(bool value)
        {
            foreach(TextMeshProUGUI content in usageOrgans)
            {
                content.transform.GetComponent<TextMeshProUGUI>().enabled = value;
            }
        }

    }
}