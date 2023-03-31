using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class laptopNav : MonoBehaviour
{
    public List<Toggle> toggles = new List<Toggle>();


    public TextMeshProUGUI nameDetails;
    public TextMeshProUGUI content;


    // data content dictionary
    private Dictionary<string, string> detailContent = new Dictionary<string, string>();
    private Dictionary<string, string> patientContent = new Dictionary<string, string>();



    void Start()
    {
        buildDataDictionary();

        //Add listener for when the state of the Toggle changes, to take action
        foreach (Toggle toggle in toggles)
        {
            toggle.onValueChanged.AddListener(delegate {
                ToggleValueChanged(toggle);
            });
        }

        //Initialise the Text to say the first state of the Toggle

    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        if (change.name == "one")
        {
            string _holder = "one";
            content.text = detailContent[_holder];
            nameDetails.text = patientContent[_holder];
            simulator_Manager.Instance.setObjectiveSix(true);

        }

        if (change.name == "two")
        {
            string _holder = "two";
            content.text = detailContent[_holder];
            nameDetails.text = patientContent[_holder];
        }

        if (change.name == "three")
        {
            string _holder = "three";
            content.text = detailContent[_holder];
            nameDetails.text = patientContent[_holder];
        }

        if (change.name == "four")
        {
            string _holder = "four";
            content.text = detailContent[_holder];
            nameDetails.text = patientContent[_holder];
        }

        if(change.name == "five")
        {
            string _holder = "five";
            content.text = detailContent[_holder];
            nameDetails.text = patientContent[_holder];
        }
    }

    void buildDataDictionary()
    {
        patientContent.Add("one", "Eseosa");
        patientContent.Add("two", "Clay");
        patientContent.Add("three", "Johnson");
        patientContent.Add("four", "Dan");
        patientContent.Add("five", "Joseph");

        detailContent.Add("one", "<color=yellow>Medical History:</color> \n " +
            "The patient has a history of hypertension, hyperlipidemia, and smoking. He has been on medication for hypertension and hyperlipidemia for the past 5 years. He has a family history of cardiovascular disease.\n " +
            "<color=yellow>Symptoms:</color> \n The patient presented to the hospital with chest pain, shortness of breath, and fatigue.\n <color=yellow>Diagnosis:</color> \n " +
            "The patient was diagnosed with coronary artery disease based on his symptoms and medical history. An angiogram was performed, which revealed significant blockages in the coronary arteries.\n<color=yellow>Treatment</color>:\n" +
            "" +
            "The patient is scheduled for angioplastic surgery to address the blockages in his coronary arteries. The procedure will involve the insertion of a catheter into the blocked artery, followed by the inflation \n" +
            "of a balloon to open up the blockage. A stent will then be placed to keep the artery open. The procedure will be performed under local anesthesia.\n <color=yellow>Recommendations:</color> The patient will need to continue taking\n" +
            " medication for hypertension and hyperlipidemia following the procedure. He will also need to make lifestyle changes, including quitting smoking, eating a healthy diet, and getting regular exercise, to reduce his \n" +
            "risk of future cardiovascular events. Follow-up appointments will be scheduled to monitor his progress and adjust his treatment plan as needed."); 


        detailContent.Add("two", "Sick ");
        detailContent.Add("three", " Needs Surgery now asap ");
        detailContent.Add("four", " The fourth is okay but maybe sick ");
        detailContent.Add("five", " This nigga is doing fine, does not need anything big \n ");

    }



}
