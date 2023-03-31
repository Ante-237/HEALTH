using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class simulator_Manager : MonoBehaviour
{
    public fading fading;
    public static simulator_Manager Instance { get; private set; }

    [Header("instructions")]
    public TextMeshProUGUI instructionsOne;
    public TextMeshProUGUI instructionsTwo;
    public Image instructionSprite;
    public Image instructionSprite2;


    [Header("Sprites Images")]
    public List<Sprite> sprites = new List<Sprite>(3);

    [Header("Scripts Goal Points")]
    public checkPosition checkPositionReception;

    [Header("Instructions Panel")]
    public GameObject instructionsPanel;



    // dictionary storing the instructions
    private Dictionary<string, string> instructions = new Dictionary<string, string>();


    int stages = 0;



    // variable for objective three
    bool objectiveThree = false;
    bool objectiveFour = false;
    bool objectiveFive = false;
    bool objectiveSix = false;
    bool objectiveSeven = false;
    bool objectiveEight = false;



    // holder of ovr manager
    private OVRManager ovrM;
    


    public void Start()
    {
        populateInstructions();
        fading.fadeIn();

        ovrM = OVRManager.instance;
        
    }

    private void Update()
    {
        instructionController();
    }


    //check for arriving reception
    public void checkReception()
    {
        if (checkPositionReception.arrivedReception())
        {
            oneCompleteSprite();

        }
        else
        {
            resetSprites();

            
        }


        if (checkPositionReception.getObjectiveTwo() && checkPositionReception.arrivedReception() && stages == 0)
        {
            instructionSprite2.sprite = sprites[0];
            // call coroutine since this is the last instruction
            StartCoroutine(changeSetInstructions(1));
        }


    }


    //check for arriving the doctors office selection and entry of code. 
    public void checkNavOffice()
    {
        if (objectiveThree)
        {
            oneCompleteSprite();
        }
        else
        {
            resetSprites();
        }

        if(objectiveFour && objectiveThree && stages == 1)
        {
            instructionSprite2.sprite = sprites[0];
            // call coroutine since this is the last instruction
            // Debug.LogError("Coroutine call sent ");
            StartCoroutine(changeSetInstructions(2));
        }

    }

    public void checkDoctorsOffice()
    {
        if (objectiveFive)
        {
            oneCompleteSprite();
        }
        else
        {
            resetSprites();
        }

        if(objectiveSix && objectiveFive && stages == 2)
        {
            instructionSprite2.sprite = sprites[0];
            // call coroutine since this is the last instruction
            StartCoroutine(changeSetInstructions(3));
        }
    }


    public void checkSurgeryStart()
    {
        if (objectiveSeven)
        {
            oneCompleteSprite();
        }
        else
        {
            resetSprites();
        }

        if(objectiveSeven && objectiveEight && stages == 3)
        {
            instructionSprite2.sprite = sprites[0];
            // call coroutine to disable the panel.
            StartCoroutine(closeInstructionsPanel());
            
        }
    }

    // decide what instructions to show
    void instructionController()
    {
            switch (stages)
            {
                case 0:
                    instructionsOne.text = instructions["one"];
                    instructionsTwo.text = instructions["two"];
                    checkReception();
                    break;
                case 1:
                    instructionsOne.text = instructions["three"];
                    instructionsTwo.text = instructions["four"];
                    checkNavOffice();
                    break;
                case 2:
                    instructionsOne.text = instructions["five"];
                    instructionsTwo.text = instructions["six"];
                    checkDoctorsOffice();
                    break;
                case 3:
                    instructionsOne.text = instructions["seven"];
                    instructionsTwo.text = instructions["eight"];
                    checkSurgeryStart();
                    // last instruction for nowwww
                    break;
                default:
                    break;
            }
       

    }


    // coroutine for changing instructions currently being displayed all at once
    IEnumerator changeSetInstructions(int value)
    {
        yield return new WaitForSeconds(2.0f);
        stages = value;
       // Debug.LogError("How many times was stages increaed + " + stages);
    }


    // coroutine to disable the handshow panel
    IEnumerator closeInstructionsPanel()
    {
        yield return new WaitForSeconds(3.0f);
        instructionsPanel.SetActive(false);
    }




    void populateInstructions()
    {
        instructions.Add("one", "Move to the Reception");
        instructions.Add("two", "Use the Panel to navigate");
        instructions.Add("three","Select the Doctors Office");
        instructions.Add("four", "Enter the code 7272 ");
        instructions.Add("five", "Take a seat");
        instructions.Add("six", "Patient Eseosa Read info");
        instructions.Add("seven", "Select surgery and teleport");
        instructions.Add("eight", "Do a right hands thumbs up to start the surgery");
    }


    //reset the pointers to zero
    void resetSprites()
    {
        instructionSprite.sprite = sprites[1];
        instructionSprite2.sprite = sprites[2];
    }

    // progress made 
    void oneCompleteSprite()
    {
        // change sprite to complete
        instructionSprite.sprite = sprites[0];
        // set sprite for the next instructions panel
        instructionSprite2.sprite = sprites[1];
    }



   
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }





    //set objective three value 
    public void setObjectiveThree(bool value)
    {
        objectiveThree = value;
    }

    public void setObjectiveFour(bool value)
    {
        objectiveFour = value;
    }

    public void setObjectiveFive(bool value)
    {
        objectiveFive = value;
    }

    public void setObjectiveSix(bool value)
    {
        objectiveSix = value;
    }

    public void setObjectiveSeven(bool value)
    {
        objectiveSeven = value;
    }

    public void setObjectiveEight(bool value)
    {
        if (objectiveSeven)
        {
            objectiveEight = value;
        }
       
    }



    // move to various areas  
     void  moveSurgery()
     {
       
        SceneManager.LoadScene("surgery");
       
     }

     void movePharmacy()
     {
        SceneManager.LoadScene("pharmacy");
        
     }

     void moveAnatomy()
     {
        SceneManager.LoadScene("anatomy");
     }

     void moveOut()
     {
         SceneManager.LoadScene("entryScene");
     }

     public void nowMoveSurgery()
     {
        Invoke("moveSurgery", 1.0f);
     }

     public void nowPharmacy()
     {
        Invoke("movePharmacy", 1.0f);
     }

    public void nowAnatomy()
    {
        Invoke("moveAnatomy", 1.0f);
    }

    public void nowOut()
    {
        Invoke("entryScene", 1.0f);
    }






}
