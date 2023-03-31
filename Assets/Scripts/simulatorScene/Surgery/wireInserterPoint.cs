using UnityEngine;

public class wireInserterPoint : MonoBehaviour
{
    SurgeryManager m;
    private bool firstTime = true;
  

    private void Start()
    {
        m = SurgeryManager.Instance;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("stringpusher"))
        {
            if (m.getStepState(2) == false && m.getStepState(1) == true)
            {
                //disabbling the string pusher tutorial and enabling the pickup for 
                // for the wire one object tutorial
                m.setTutorialStep(false, 6);
                m.setTutorialStep(true, 7);
      

                m.changeState(SurgeryManager.stages.FOUR);
                m.setStepState(true, 2);
            }
            else
            {
                if (!m.getStepState(9))
                {
                    if (firstTime)
                    {
                        m.increaseErrors();
                        m.addErrorVibe("Touch the Tube insertion at the wrong Time");
                        firstTime = false;
                    }
                   
                }

            }
        }    
    }

    


    


}
