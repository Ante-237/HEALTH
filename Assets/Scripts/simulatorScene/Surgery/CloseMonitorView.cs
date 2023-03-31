using UnityEngine;

public class CloseMonitorView : MonoBehaviour
{

    SurgeryManager m;

    private void Start()
    {
        m = SurgeryManager.Instance;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (m.getStepState(6))
        {
            m.checkingStageTwelve();
        }


        if (m.getStepState(10))
        {
            m.changeState(SurgeryManager.stages.SEVENTEEN);
            m.setStepState(true, 11);

        }

    }


}
