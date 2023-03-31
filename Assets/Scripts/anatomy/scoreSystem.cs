using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

namespace anatomy.levelone
{
    public class scoreSystem: MonoBehaviour
    {

        public TextMeshProUGUI scoreText;
        public Image percentageRate;
        public anatomySettings settings;
        private string outcomeResult;

        [SerializeField]
        public float TrackingFill = 0;


        public void UpdateUIScoring()
        {
            checkTextResult();
            setTextContents();
            updateUIPercentage();
        }

        public void setTextContents()
        {
            scoreText.text = "Completed: " + settings.score + "\n" + "Errors: " + settings.errors +
                "\nUncompleted: " + (settings.highestScore - settings.score) + "\n\n\n\t" + outcomeResult
                + " \n\t<color=yellow> RETRIES : </color>" + settings.retries;
        }

        public void checkTextResult()
        {

            if (settings.score < 4)
            {
                outcomeResult = settings.resultText[0];
            }
            else if (settings.score >= 4 && settings.score <= 6)
            {
                outcomeResult = settings.resultText[1];
            }
            else
            {
                outcomeResult = settings.resultText[2];
            }
        }

        public void updateUIPercentage()
        {
            float percentage = settings.score * 0.125f;
            percentageRate.fillAmount = percentage;
            TrackingFill = percentageRate.fillAmount;
        }
    }
}