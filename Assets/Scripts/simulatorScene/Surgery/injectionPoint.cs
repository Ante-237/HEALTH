
using UnityEngine;

public class injectionPoint : MonoBehaviour
{

    private bool firstTime = true;

    SurgeryManager m;
    private void Start()
    {
        m = SurgeryManager.Instance;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("injection"))
        {
            if (!m.getStepState(0))
            {
                // for ghost hand tutorials 
                m.setTutorialStep(false, 2);
                m.setTutorialStep(true, 3);

                m.changeState(SurgeryManager.stages.TWO);
                m.setStepState(true, 0);

              
               
            }
            else
            {
                if (!m.getStepState(10))
                {
                    if (firstTime)
                    {
                        m.increaseErrors();
                        m.addErrorVibe("You picked up the Syring at the wrong Time");
                        firstTime = false;
                    }
                 
                }
               
            }
        }

    }

}
