using Oculus.Interaction.Samples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuClick : MonoBehaviour
{
    [SerializeField]
    private List<Toggle> sceneToggle = new List<Toggle>();

    [SerializeField]
    private SceneLoader sceneLoader;


    private string[] tags = new string[5] { "exit", "anatomy", "practice", "surgery", "tutorial" };

    void Start()
    {
        //Fetch the Toggle GameObject
        
        //Add listener for when the state of the Toggle changes, to take action
        foreach(Toggle toggle in sceneToggle)
        {
            toggle.onValueChanged.AddListener(delegate {
                ToggleValueChanged(toggle);
            });
        }
   
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        if (change.CompareTag(tags[0]))
        {
            if (change.isOn)
            {
                sceneLoader.Load("entryScene");
            }
            
        }else if (change.CompareTag(tags[1]))
        {
            if (change.isOn)
            {
                sceneLoader.Load("anatomy");
            }
           
        }else if (change.CompareTag(tags[2]))
        {
            if (change.isOn)
            {
                sceneLoader.Load("anatomyLevelOne");
            }
            
        }else if (change.CompareTag(tags[3]))
        {    
            if (change.isOn)
            {
                sceneLoader.Load("surgery");
            }
        }else if (change.CompareTag(tags[4]))
        {
            if (change.isOn)
            {
                sceneLoader.Load("tutorialScene");
            }
          
        }
    }
}
