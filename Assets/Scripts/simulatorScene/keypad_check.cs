using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class keypad_check : MonoBehaviour
{
    [Header("Code Output")]
    public TextMeshProUGUI code_text;
    List<string> keys = new List<string>(9);
   


    [Header("ToogleScript")]
    public navigateDifferent navigateDifferent;

    [Header("Teleport Points")]
    public List<Transform> points = new List<Transform> ();

    public GameObject player;

    //public OVRCameraRig cameraRef;

    // hospital position
    [SerializeField] private Transform target_position;
    
   

 
    private void Start()
    {
        addlist_Elements();
        if(code_text != null)
        {
            code_text.text = "";
        }


        // position the fading
        //positionCanvasInFront();
    }

    public void buttonZero()
    {
        if (checkLength())
        {
            code_text.text +=  keys[0];
        }
    }


    public void buttonOne()
    {
        if (checkLength())
        {
            code_text.text += keys[1];
        }
    }


    public void buttonTwo()
    {
        if (checkLength())
        {
            code_text.text += keys[2];
        }
    }


    public void buttonThree()
    {
        if (checkLength())
        {
            code_text.text += keys[3];
        }
    }


    public void buttonFour()
    {
        if (checkLength())
        {
            code_text.text += keys[4];
        }
    }


    public void buttonFive()
    {
        if (checkLength())
        {
            code_text.text += keys[5];
        }
    }


    public void buttonSix()
    {
        if (checkLength())
        {
            code_text.text += keys[6];
        }
    }


    public void buttonSeven()
    {
        if (checkLength())
        {
            code_text.text += keys[7];
        }
    }


    public void buttonEight()
    {
        if (checkLength())
        {
            code_text.text += keys[8];
        }
    }


    public void buttonNine()
    {
        if (checkLength())
        {
            code_text.text += keys[9];
        }
    }


    public void checkCode()
    {
        if(code_text != null)
        {
            if(code_text.text == "7272")
            {
                code_text.text = "RIGHT";
                StartCoroutine(changePosition());
                // string toggle = navigateDifferent.activeToggle();

                // since code is correect set objective four to valid
                simulator_Manager.Instance.setObjectiveFour(true);

            }
        }
    }

    public void eraseCode()
    {
        code_text.text = "";
    }


    private bool checkLength()
    {
        string code = code_text.text;
        if (code.Length < 4)
        {
            return true;
        }

        else return false;
    }


    void addlist_Elements()
    {
        keys.Add("0");
        keys.Add("1");
        keys.Add("2");
        keys.Add("3");
        keys.Add("4");
        keys.Add("5");
        keys.Add("6");
        keys.Add("7");
        keys.Add("8");
        keys.Add("9");
    }

    IEnumerator changePosition()
    {
       yield return new WaitForSeconds(0.1f);
        if (player != null)
        {
            string toggle = navigateDifferent.activeToggle();
            foreach(Transform point in points)
            {
                // compare tags with an match choosen teleport scene. 
                if (point.CompareTag(toggle))
                {
                    //start the fading sequence with fading canvas
                    //startFadingSequence();
                    // send player camera to right location 
                    if (point.CompareTag("surgery"))
                    {
                        // teleport to surgery room
                        SceneManager.LoadScene("surgery");
                    }

                    if (point.CompareTag("pharmarcy"))
                    {
                        // teleport to pharmacy
                        SceneManager.LoadScene("pharmacy");
                    }


                    if (point.CompareTag("anatomy"))
                    {
                        // teleport to anatomy room
                        SceneManager.LoadScene("anatomy");
                    }


                    if (point.CompareTag("office"))
                    {
                        player.transform.position = point.position;
                        player.transform.GetChild(0).transform.position = point.position;
                        player.transform.GetChild(1).transform.position = point.position;
                    }

                    if (toggle == "surgery")
                    {
                        //turnCamera(-100f);
                    }
                }
            }
        }
    }


    // moves to doctors office
    public void toDoctorOffice()
    {
        player.transform.position = target_position.position;
        player.transform.GetChild(0).transform.position = target_position.position;
        player.transform.GetChild(1).transform.position = target_position.position;

        Debug.LogError("Moving to Doctors Office");
    }

    // fading in and out with 
    /*
    void startFadingSequence()
    {
        // start fading in 
        StartCoroutine(FadeInCanvas());


        // start fading out
        StartCoroutine(FadeOutCanvas());

    }
    /*

    // reduce the alpha of the mesh renderer image
    /*
    public IEnumerator FadeOutCanvas()
    {
       if(canvasFading != null)
        {
            // position canvas in front of camera
            positionCanvasInFront();
            Image fadingImage = canvasFading.transform.GetChild(0).GetComponent<Image>();
            while (fadingImage.color.a > 255)
            {
                Color objectColor = fadingImage.color;
                float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);
         

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                fadingImage.color = objectColor;
                yield return null;
            }
        }
    }   
    */
    
    // increase renderer of the mesh renderer
    /*
    public IEnumerator FadeInCanvas()
    {
       if(canvasFading != null)
        {
            // position canvas in front of Camera
            positionCanvasInFront();
            Image fadingImage = canvasFading.transform.GetChild(0).GetComponent<Image>();
            while (fadingImage.color.a < 255)
            {
                Color objectColor = fadingImage.color;
                float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);
      

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                fadingImage.color = objectColor;
                yield return null;
            }
        }
    }
    */
        
    // getting camera reference and position 
    /*
    void positionCanvasInFront()
    {
        Vector3 cameraPosition = cameraRef.transform.position;
        Quaternion cameraRotation = cameraRef.transform.rotation;
        canvasFading.transform.position = new Vector3(cameraPosition.x, cameraPosition.y, cameraPosition.z + 2.0f);
        canvasFading.transform.rotation = cameraRotation;
    }
    */


    // make camera angle specific
    /*
    void turnCamera(float amount)
    {
        cameraRef.transform.rotation = new Quaternion(cameraRef.transform.rotation.x, amount, cameraRef.transform.rotation.z, 0);
        // turn canvas to adjust with view as well. 
     
    }
    */
    
}
