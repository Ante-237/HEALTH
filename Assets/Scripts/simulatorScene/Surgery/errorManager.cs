using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using Oculus.Interaction.GrabAPI;

public class errorManager : OVRSceneLoader
    {

    [Header("Surgery Manager")]
    [Tooltip("This will hold a reference to the surgery manager")]
    private SurgeryManager m;
    private bool firstTime = false;
   


    private int errors = 0;
    private static List<string> advice = new List<string>();


    // working with OVRManager 
    void Start()
    {
        m = SurgeryManager.Instance;

        // random test codes





    }

 



    private void Update()
    {
        // if last step get all the advice and errors
        if (m.getStepState(11) && firstTime == false)
        {
            advice = m.ErrorPoints;
            firstTime = true;
           
        }
    }

}
