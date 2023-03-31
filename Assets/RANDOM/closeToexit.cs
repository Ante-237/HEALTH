using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeToexit : MonoBehaviour
{

    SurgeryManager m;

    private void Start()
    {
        m = SurgeryManager.Instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(m.getStepState(11))
        {
            m.changeState(SurgeryManager.stages.NINETEEN);
        }


        m.updateFinalScore();
       
    }
}
