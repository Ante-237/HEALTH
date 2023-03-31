using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPosition : MonoBehaviour
{
    //check if we arrive reception
    bool objectiveOne = false;
    bool objectiveTwo = false;

    [SerializeField] private TutorialManager tutorialManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "npc")
        {

            objectiveOne = true;
            tutorialManager.showGuideSwipe();
            
        }
        else
        {
            objectiveOne = false;
        }
    }

    public bool arrivedReception()
    {
        return objectiveOne;
    }

    //check if enter key was pressed
    public void touching()
    {
        objectiveTwo = true;
    }

    //return value for checking objective two called by manager script
    public bool getObjectiveTwo()
    {
        return objectiveTwo;
    }




   
}
