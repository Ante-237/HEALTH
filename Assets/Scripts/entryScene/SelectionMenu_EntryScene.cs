using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SelectionMenu_EntryScene : MonoBehaviour
{
    public List<Toggle> toggles = new List<Toggle>(4);
    public List<Texture> rawImages = new List<Texture>(4);


    public TextMeshProUGUI heading;
    public TextMeshProUGUI content;
    public RawImage rawImage;



    void Start()
    {

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
        if (change.name == "simulator")
        {
            content.text = "Welcome to Medical Surgery Simulation, Enjoy the experience";
            rawImage.texture = rawImages[0];
            heading.text = "SIMULATOR";

        }

        if (change.name == "tutorials")
        {
            content.text = "New To Virtual Space \n This is a good place to start \n Learn How to Move and Rotate with \n HandTracking ";
            rawImage.texture = rawImages[1];
            heading.text = "TUTORIALS";

        }

        if (change.name == "devteam")
        {
            content.text = "<color=yellow>Lead Programmer</color>    Nwalahnjie Anye \n " +
                "<color=yellow>Level Design and Modeling</color>    Eseosa \n " +
                "<color=yellow>Voice Over</color>    Kenzo \n <color=yellow> Lighting and Design</color>    Gatwaza \n" +
                "<color=yellow>Level Design</color>    Isaac";
            rawImage.texture = rawImages[2];
            heading.text = "DEV TEAM";
        }

        if (change.name == "exit")
        {
            content.text = "Exiting simulator, See you next Time";
            rawImage.texture = rawImages[3];
            heading.text = "EXIT";
        }
    }





}


