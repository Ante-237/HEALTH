using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TutorialManager : MonoBehaviour
{

    public GameObject instructionsTutorial;
    public GameObject swipeInstruction;
    public GameObject swipeInstructionTwo;

    public void Start()
    {
        StartCoroutine(instructionTutorial());
    }


    // start tutorial for hand show
    IEnumerator instructionTutorial()
    {
        instructionsTutorial.SetActive(true);
        yield return new WaitForSeconds(30.0f);
        instructionsTutorial.SetActive(false);
    }


    // tutorial swipe for navigation panel
    public void showGuideSwipe()
    {
        StartCoroutine(swipInstruction());
    }


    IEnumerator swipInstruction()
    {
        swipeInstruction.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        swipeInstruction.SetActive(false);
    }


    // tutorial swipe for laptop panel 
    public void showGuideSwipeSecond()
    {
        StartCoroutine(swipInstructionTwo());
    }

    IEnumerator swipInstructionTwo()
    {
        swipeInstructionTwo.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        swipeInstruction.SetActive(false);
    }
}
