using UnityEngine;
using TMPro;
using UnityEngine.UI;


namespace anatomy.levelone
{
    public class partSystem : MonoBehaviour
    {
        public completionSettings completionSettings;
        public anatomySettings anatomySettings;

        [Header("Curved Board Update")]
        public Image[] completionSprite =  new Image[8];
        public TextMeshProUGUI[] completionText = new TextMeshProUGUI[8];


        public void updateUI()
        {
            for(int i = 0; i < 8; i++)
            {
                if (completionSettings.state[i] == completionSettings.status.COMPLETE)
                {
                    completionSprite[i].sprite = completionSettings.completionStatus[1];
                    completionText[i].text = completionSettings.completionText[1];
                  
                    
                }
            }
        }

        public void updateScore()
        {
            for(int i = 0; i < 8; i++)
            {
                if (completionSettings.state[i] == completionSettings.status.COMPLETE)
                {
                   
                    anatomySettings.score += 1;
                    
                }
            }
        }

        


       
    }

}
