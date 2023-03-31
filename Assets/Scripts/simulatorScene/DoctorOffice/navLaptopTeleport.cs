using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Oculus.Interaction.Samples;

public class navLaptopTeleport : MonoBehaviour
{

    public List<Toggle> toggles = new List<Toggle>();
    public TextMeshProUGUI heading;

    private List<string>  sceneNames = new List<string>();
    public GameObject Player;
    private string teleportScene = "surgery";


    [Tooltip("Use to load various Scenes with passed in instructions")]
    [SerializeField] private SceneLoader sceneLoader;



    void Start()
    {
        //setup dictionary
        setupDictionaryTeleport();

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
        if (change.name == "surgery")
        {
         
         
            heading.text = "SUGERY ROOM";
            teleportScene = sceneNames[0];

        }

        if (change.name == "patient")
        {
           
            heading.text = "PATIENTS ROOM";
            Debug.Log("No patient Room for now ");
            // teleportScene = sceneNames[1];
        }

        if (change.name == "pharmacy")
        {
          
            heading.text = "PHARMACY";
            teleportScene = sceneNames[2];
        }

        if (change.name == "lab")
        {

            heading.text = "LAB";
            Debug.Log("No lab for now");
            //teleportScene = sceneNames[3];
        }

        if(change.name == "x-ray")
        {
            heading.text = "X-RAY ROOM";
            Debug.Log("No x-ray room for now");
            //teleportScene = sceneNames[4];
        }

        if(change.name == "anatomy")
        {
            heading.text = "ANATOMY ROOM";
            teleportScene = sceneNames[5];
        }
    }

    void setupDictionaryTeleport()
    {
        sceneNames.Add("surgery");
        sceneNames.Add("patient");
        sceneNames.Add("pharmacy");
        sceneNames.Add("lab");
        sceneNames.Add("x-ray");
        sceneNames.Add("anatomy");
    }

    /*
    IEnumerator changeLocation(string _name)
    {
        yield return new WaitForSeconds(1.5f);
        // load the right scene passed 
        SceneManager.LoadScene(_name);
    }
    */
    
    public void teleportToLocation()
    {
        //teleport called objective is complete
        simulator_Manager.Instance.setObjectiveSeven(true);
        sceneLoader.Load(teleportScene);

       // StartCoroutine(changeLocation(teleportScene));
    }
    

}
