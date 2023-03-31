using anatomy.levelone;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class timingSystem : MonoBehaviour
{
    public anatomySettings settings;

    public TextMeshProUGUI timerText;

    private float minutes;
    private float seconds;

    public UnityEvent finalScoreUpdateBoard;


    public void setTimer()
    {
       
        if (!settings.isStarted)
        {
            
            minutes = Mathf.Round(settings.timer / 60.0f);
            seconds = Mathf.Round(settings.timer % 60.0f);
            timerText.text = "" + minutes + " : " + seconds.ToString();
        }  
    }

    private void Update()
    {
        if (settings.timerRunning)
        {
            runTime();
        }
    }


    public void startTimer()
    {
        if (settings.isStarted)
        {
            settings.timerRunning = true;
        } 
    }

    public void runTime()
    {
        settings.timer -= Time.deltaTime * settings.timerReduction;
        minutes = Mathf.Round(settings.timer / 60.0f);
        seconds = Mathf.Round(settings.timer % 60.0f);
        timerText.text = "" + minutes + " : " + seconds.ToString();


        if(settings.timer <= 0.0f)
        {
            finalScoreUpdateBoard?.Invoke();
            timerText.text = "<color=red> 00 : 00 </color>";
            settings.timerRunning = false;
            settings.isStarted = false;
        }

    }

}
