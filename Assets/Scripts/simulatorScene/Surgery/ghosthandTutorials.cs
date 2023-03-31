using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghosthandTutorials : MonoBehaviour
{
    SurgeryManager m;
    bool firstTime = true;
    bool syringInsert = false;
    bool bloodBagInsert = false;
    bool pusherInsert = false;
    bool wireOne = false;
    bool sliderDown = false;
    bool dyetube = false;
    bool dyebag = false;

    private void Start()
    {
        m = SurgeryManager.Instance;
    }



    // check for player first time at surgery location
    private void OnTriggerEnter(Collider other)
    { 
            if (firstTime)
            {
                m.setTutorialsFalse();
                m.setTutorialStep(true, 0);
                m.setTutorialStep(true, 1);
                firstTime = false;
            }   
    }


    //checking if syring is picked up
    public void syringSelected()
    {
        
        m.setTutorialStep(false, 1);
        if (!syringInsert)
        {
            m.setTutorialStep(true, 2);
            syringInsert = true;
        }
       
    }

    // when the blood bag is picked up
    // show insertion point and disable pickup point
    public void bloodSelectionBag()
    {

        m.setTutorialStep(false, 3);
        if (!bloodBagInsert)
        {
            m.setTutorialStep(true, 4);
            bloodBagInsert = true;
        }
          
    }


    // when string pusher is picked up 
    // disable pickup tutorial and show how to push it in
    public void PusherSelection()
    {
        m.setTutorialStep(false, 5);
        if (!pusherInsert)
        {
            m.setTutorialStep(true, 6);
            pusherInsert = true;
        }

    }

    // when wireone is picked up
    // disable pickup tutorial and show how to insert wire
    public void WireOneInsert()
    {
        m.setTutorialStep(false, 7);
        if (!wireOne)
        {
            m.setTutorialStep(true, 8);
            wireOne = true;
        }
    }


    // when the slider is selected stop the tutorial 
    // and highlight the lookat potential for the x-ray screens. 
    public void sliderEffect()
    {
        m.setTutorialStep(false, 9);
        if (!sliderDown)
        {
            m.setTutorialStep(true, 10);
            m.setTutorialStep(true, 11);
            sliderDown = false;
        }

    }


    // when the dye tube is selected, stop showing
    // and play for insertion into syring. 
    public void dyeTubeInsert()
    {
        m.setTutorialStep(false, 15);
        if (!dyetube)
        {
            m.setTutorialStep(true, 8);
            dyetube = true;
        }

    }


    // when the dye bag is selected, stop showing handss.
    // start showing dye bag addition. 

    public void DyeBagSelected()
    {

        m.setTutorialStep(false, 16);
        if (!dyebag)
        {
            // set the dye bag to true
            m.setTutorialStep(true, 4);
            m.setTutorialStep(false, 10);
            m.setTutorialStep(false, 11);
            dyebag = false;
        }

    }


    // picking up the mesh tube and addition to the tube slider. 

    


}
