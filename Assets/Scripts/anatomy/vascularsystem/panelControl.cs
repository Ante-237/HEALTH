using Oculus.Interaction.Samples;
using Oculus.Platform.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class panelControl : MonoBehaviour
{
    [SerializeField]
    private bodyFunctions bodyFunctions;

    [SerializeField]
    private TextMeshProUGUI heading;

    [SerializeField]
    private TextMeshProUGUI Content;

    [SerializeField]
    private Toggle[] toggles = new Toggle[8];

    private void Start()
    {
        foreach(var t in toggles)
        {
            t.onValueChanged.AddListener(delegate {
                ToggleValueChanged(t);
            });
        }
    }


    /// <summary>
    /// to be triggered by an event when a body part is picked up
    /// passing in the reference that matches the part index to set
    /// the right content
    /// </summary>
    /// <param name="i"></param>
    public void liverDetails(int i)
    {
        bodyFunctions.pContent[0] = bodyFunctions.organNames[i];
        bodyFunctions.pContent[1] = bodyFunctions.description[i];
        bodyFunctions.pContent[2] = bodyFunctions.functions[i];
        bodyFunctions.pContent[3] = bodyFunctions.location[i];
        bodyFunctions.pContent[4] = bodyFunctions.size[i];
        bodyFunctions.pContent[5] = bodyFunctions.diseases[i];
        bodyFunctions.pContent[6] = bodyFunctions.importance[i];
        bodyFunctions.pContent[7] = bodyFunctions.treatment[i];
        bodyFunctions.pContent[8] = bodyFunctions.importance[i];
        checkToggleOn();
    }

    public void setDetails(int i)
    {
        heading.text = bodyFunctions.headingNames[i];
        Content.text = bodyFunctions.pContent[i];
    }

    public void ToggleValueChanged(Toggle t)
    {
        if (t.name.Equals("description"))
        {
            if (t.isOn)
            {
                setDetails(1);
            }

        }else if (t.name.Equals("location"))
        {
            if (t.isOn)
            {
                setDetails(3);
            }
        }else if (t.name.Equals("diseases"))
        {
            if (t.isOn)
            {
                setDetails(5);
            }
           
        }else if (t.name.Equals("functions"))
        {
            if (t.isOn)
            {
                setDetails(2);
            }
        }else if (t.name.Equals("size"))
        {
            if (t.isOn)
            {
                setDetails(4);
            }
        }else if (t.name.Equals("importance"))
        {
            if (t.isOn)
            {
                setDetails(6);
            }
        }else if (t.name.Equals("treatment"))
        {
            if (t.isOn)
            {
                setDetails(7);
            }
        }
       

    }

    public void checkToggleOn()
    {
        for(int i = 0; i < toggles.Length; i++)
        {
            if (toggles[i].isOn)
            {
                if (toggles[i].name.Equals("description"))
                {
                    setDetails(1);
                }else if (toggles[i].name.Equals("location"))
                {
                    setDetails(3);
                }else if (toggles[i].name.Equals("diseases"))
                {
                    setDetails(5);
                }else if (toggles[i].name.Equals("functions"))
                {
                    setDetails(2);
                }else if (toggles[i].name.Equals("size"))
                {
                    setDetails(4);
                }else if (toggles[i].name.Equals("importance"))
                {
                    setDetails(6);
                }else if (toggles[i].name.Equals("treatment"))
                {
                    setDetails(7);
                }
            }
        }
    }




  

}
