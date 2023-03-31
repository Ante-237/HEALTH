using UnityEngine;

public class bloodBagPoint : MonoBehaviour
{

    SurgeryManager m;
    bool firstRemoval = false;

    private void Start()
    {
        m = SurgeryManager.Instance;
    }

    // adding the blood bag in

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("bloodbag"))
        {
            if (m.getStepState(1) == false && m.getStepState(0) == true)
            {
                // setting tutorial for blood bag touching
                m.setTutorialStep(false, 4);
                m.setTutorialStep(true, 5);
               
                m.changeState(SurgeryManager.stages.THREE);
                m.setStepState(true, 1);
            }

            // adding codition for the blood bag to increase size and change material after this step three
        }


        // set to eleven only when dye wire and blood bag are removed
        if (other.gameObject.CompareTag("blackDye"))
        {
            if(m.getStepState(5) == true && m.getStepState(6) == true)
            {
                m.changeState(SurgeryManager.stages.ELEVEN);
                m.setStepState(true, 7);


                // when dye bag is added disable dye bag addition
                // enable looking at the screen 
                // enable sliding out 
                m.setTutorialStep(false, 4);
                m.setTutorialStep(true, 10);
                m.setTutorialStep(true, 11);

                //sliding out true. 
                m.setTutorialStep(true, 12);

            }
        }
    }


    // taking out the bloodbag
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("bloodbag"))
        {
            if (m.getStepState(4) == true && m.getStepState(1) == true)
            {
                m.changeState(SurgeryManager.stages.NINE);
                m.setStepState(true, 5);


                // when blood bag is removed., diable all looking at screens and bag removal tutorial as well. 
                // we enable tutorial for removing the wire.
              
               
                if (!firstRemoval)
                {
                    m.setTutorialStep(false, 14);

                    // set pickup on second wire yellow
                    m.setTutorialStep(true, 15);
                    firstRemoval = true;
                }
                
            }
        }



    }
    
}
