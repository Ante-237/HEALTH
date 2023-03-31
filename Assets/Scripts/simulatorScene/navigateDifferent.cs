using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class navigateDifferent : MonoBehaviour
{
    [Header("Toggles")]
    public List<Toggle> toggles = new List<Toggle>();


    [Header("Room Details")]
    public TextMeshProUGUI HeaderDetails;
    public TextMeshProUGUI bodyDetails;


    // details to be displayed for each room 
    private Dictionary<string, string> _information = new Dictionary<string, string>(18);
    private string activeScene = "reception";

    bool objectiveOfficeSelect = false;



    void Start()
    {
        //create dictionary with content
        setupDictionaryContent();

        // all content of dictionary

        foreach(Toggle toggle in toggles)
        {
            if (toggle.CompareTag("reception"))
            {
                toggle.enabled = true;
                activeScene = "reception";
            }
            // add listener for classes 
            toggle.onValueChanged.AddListener(delegate
            {
                ToggleValueChanged(toggle);

            });


        }
    }

    // change content of the display board depending on the toggle state
    void ToggleValueChanged(Toggle toggle)
    {

        if (toggle.isOn)
        {
            if (toggle.CompareTag("reception"))
            {
                activeScene = "reception";
                changeDetails(_information["H_Reception"], _information["B_Reception"]);
            }

            if (toggle.CompareTag("surgery"))
            {
                activeScene = "surgery";
                changeDetails(_information["H_Surgery"], _information["B_Surgery"]);
            }

            if (toggle.CompareTag("anatomy"))
            {
                activeScene = "anatomy";
                changeDetails(_information["H_Anatomy"], _information["B_Anatomy"]);
            }

            if (toggle.CompareTag("lab"))
            {
                activeScene = "lab";
                changeDetails(_information["H_Lab"], _information["B_Lab"]);
            }

            if (toggle.CompareTag("office"))
            {
                activeScene = "office";
                changeDetails(_information["H_Office"], _information["B_Office"]);
                // doctor office selected, change value of objective 3 to true
                simulator_Manager.Instance.setObjectiveThree(true);
            }

            if (toggle.CompareTag("patient"))
            {
                activeScene = "patient";
                changeDetails(_information["H_Patient"], _information["B_Patient"]);
            }

            if (toggle.CompareTag("x-ray"))
            {
                activeScene = "x-ray";
                changeDetails(_information["H_X-Ray"], _information["B_X-Ray"]);
            }

            if (toggle.CompareTag("equipment"))
            {
                activeScene = "equipment";
                changeDetails(_information["H_Equipment"], _information["B_Equipment"]);
            }

            if (toggle.CompareTag("pharmarcy"))
            {
                activeScene = "pharmarcy";
                changeDetails(_information["H_Pharmacy"], _information["B_Pharmacy"]);
 
            }




        }
    }


    void setupDictionaryContent()
    {
        // reception details
        _information.Add("H_Reception", " RECEPTION ");
        _information.Add("B_Reception", "IN THE RECEPTION ROOM YOU GET TO CHOOSE WHERE YOU WANNA GO");

        // surgery details
        _information.Add("H_Surgery", " SURGERY ");
        _information.Add("B_Surgery", "IN THE SURGERY ROOM WE PERFORM SOME ADVANCE SURGERY ");

        // anatomy details
        _information.Add("H_Anatomy", " ANATOMY ");
        _information.Add("B_Anatomy", " IN THE ANATOMY ROOM WE PERFROM SOME CRAZY LOOK AT HUMAN ORGANS ");


        //lab details
        _information.Add("H_Lab", " LAB ");
        _information.Add("B_Lab", " IN THE LAB ROOM WE USE SOME CRAZY GOOD EQUIPMENT ");

        //office details 
        _information.Add("H_Office", " STUDENT OR DOCTOR OFFICE ");
        _information.Add("B_Office", " WE DO SOME WORK IN THE VARIOUS OFFICE, LOOKING AT VARIOUS PATIENTS");

        // patient details
        _information.Add("H_Patient", " PATIENTS CARE ");
        _information.Add("B_Patient", " HERE YOU CAN TAKE A LOOK AT VARIOUS PATIENTS ");

        // x-ray details.
        _information.Add("H_X-Ray", " X-RAY ");
        _information.Add("B_X-Ray", " YOU CAN PERFORM X-RAY HERE ON DIFFERENT PARTS OF THE HUMAN BODY ");

        // equipment details.
        _information.Add("H_Equipment", " EQUIPMENT");
        _information.Add("B_Equipment", " LEARN HOW TO USE DIFFERENT MEDICAL EQUIPMENTS ");

        // pharmarch details.
        _information.Add("H_Pharmacy", " PHARMACY ");
        _information.Add("B_Pharmacy", " THERE YOU CAN CHECK OUT DIFFERENT TYPES OF DRUGS ");

    }

    // dynamic change of content in header and body of the panel
    void changeDetails(string header, string body)
    {
        HeaderDetails.text = "" + header;
        bodyDetails.text = "" + body;
    }

    public string activeToggle()
    {
        return activeScene;
    }
}
