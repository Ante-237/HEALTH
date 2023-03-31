using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDoctorPosition : MonoBehaviour
{
    [SerializeField] private TutorialManager tutorialManager;

    // check if player has arrived the doctors office
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "npc")
        {
            simulator_Manager.Instance.setObjectiveFive(true);
            tutorialManager.showGuideSwipeSecond();

        }
    }
}
