using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class stringCheckPoint : MonoBehaviour
{
    SurgeryManager m;

    private bool[] firsttimes = new bool[5] { true, true, true, true, true };

    private void Start()
    {
        m = SurgeryManager.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("stringOne"))
        {
            if (m.getStepState(3) == false && m.getStepState(2) == true)
            {
                m.changeState(SurgeryManager.stages.FIVE);
                m.setStepState(true, 3);


                // disable the tutorial for showing how to push and show
                // how to slide the wire in
                m.setTutorialStep(false, 8);
                m.setTutorialStep(true, 9);
            }
           
        }

        // here the new tube is placed in
        if (other.gameObject.CompareTag("dyetube"))
        {
            if (m.getStepState(5) == true && m.getStepState(4) == true)
            {
                m.changeState(SurgeryManager.stages.TEN);
                m.setStepState(true, 6);
                // when dye tube is added , disable dye tube animation
                // enable sliding down animation. 
                // enabling the look at monitor tutorials as well. 
                m.setTutorialStep(false, 15);
                // disable string input
                m.setTutorialStep(false, 8);

                // slider down
                m.setTutorialStep(true, 9);
                // look at monitors
                m.setTutorialStep(true, 10);
                m.setTutorialStep(true, 11);
            }
            else
            {
                if (firsttimes[3])
                {
                    m.addErrorVibe("You Picked up the Catheter Dye Tube at the Wrong Time");
                    m.increaseErrors();
                    firsttimes[3] = false;
                }           
            }
        }


        if (other.gameObject.CompareTag("meshTube"))
        {
            if(m.getStepState(9) == true && m.getStepState(4) == true)
            {
                m.changeState(SurgeryManager.stages.FOURTEEN);
                m.setStepState(true, 10);
            }
            else
            {
                if(firsttimes[4])
                {
                    m.addErrorVibe("Picked up Catheter Mesh Tube at wrong Time");
                    m.increaseErrors();
                    firsttimes[4] = false;
                }
               
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("stringOne"))
        {
            if (m.getStepState(3) == true)
            {
                m.changeState(SurgeryManager.stages.EIGHT);
                m.setStepState(true, 4);


                // disable looking at screen view show taking out the 
                // blood bag. 


                // will show bag removal if only its string removal is true. 

                if (m.getTutorialStep(13))
                {
                    m.setTutorialStep(false, 13);
                    m.setTutorialStep(true, 14);
                }
            }
            else
            {
                if (firsttimes[2])
                {
                    m.increaseErrors();
                    m.addErrorVibe("Took out the Catheter Tube at the wrong Time");
                    firsttimes[2] = false;
                }
            }
        }


        if (other.gameObject.CompareTag("dyetube"))
        {
            if(m.getStepState(6) == true && m.getStepState(8) == true)
            {
                m.changeState(SurgeryManager.stages.THIRTEEN);
                m.setStepState(true, 9);
                // when finishing sliding out. 
                // disable all tutorials and show pciking up the mesh tube. 
                m.setTutorialStep(false, 12); // ensuring tutorial for sliding up is false. 
                m.setTutorialStep(false, 13);
                m.setTutorialStep(true, 18);
            }
            else
            {
                if (firsttimes[0])
                {
                    m.increaseErrors();
                    m.addErrorVibe("Took out the Catheter Contrast Dye Tube at the Wrong Time");
                    firsttimes[0] = false;
                }
              
            }
        }


        if (other.gameObject.CompareTag("meshTube"))
        {
            if(m.getStepState(10) && m.getStepState(11))
            {
                m.changeState(SurgeryManager.stages.EIGHTTEEN);
                m.setStepState(true, 11);
            }
            else
            {
                if (firsttimes[1])
                {
                    m.increaseErrors();
                    m.addErrorVibe("Took out Catheter mesh Tube at the wrong Time");
                    firsttimes[1] = false;
                }
               
            }
        }

    }

}
