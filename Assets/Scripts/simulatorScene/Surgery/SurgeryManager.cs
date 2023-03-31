using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Oculus.Interaction;
using UnityEngine.SceneManagement;

public class SurgeryManager : MonoBehaviour
{
    public static SurgeryManager Instance { get; private set; }

    [Header("The Wires")]
    [SerializeField] protected List<GameObject> _wires = new List<GameObject>(2);

    [Header("Instructions Script")]
    [SerializeField] private surgeryInstructions surgeryInstructions;


    [SerializeField] public enum stages
    {
        ONE,
        TWO,
        THREE, 
        FOUR, 
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        ELEVEN,
        TWELVE,
        THIRTEEN,
        FOURTEEN,
        FIFTEEN,
        SIXTEEN,
        SEVENTEEN,
        EIGHTTEEN,
        NINETEEN
    };

    // progress tracker
    public  stages _stages;


   

    
    // line Renderer used for each wire
    [SerializeField] protected List<LineRenderer> _wire_renderer = new List<LineRenderer>();

    // percentage area
    [SerializeField] private TextMeshProUGUI percentageProgress;
    [SerializeField] private Image percentageImage;
    float percentageHolder = 0;
    string percentageText;


    [Header("BloodBag Info")]
    [SerializeField] private GameObject _BloodBag;
    [SerializeField] private Material _BloodBag_Material;


    [Header("DyeBag Info")]
    [SerializeField] private GameObject _DyeBag;

    [Header("HeartSectionInfo")]
    [SerializeField] private GameObject _HeartArtery;
    [SerializeField] private Material _HeartArtery_Material;
    private Material previous_ArteryMaterial;


    [Header("Tumor Section Info")]
    [SerializeField] private GameObject _tumor_Right;
    [SerializeField] private GameObject _tumor_Left;

    [Header("Pusher Inserter Info")]
    [SerializeField] private Grabbable _inserter_Grabbable;


    [Header("Syring Info")]
    [SerializeField] private Grabbable Syring_Grabble;


    [Header("Balloon Info")]
    [SerializeField] private GameObject _inflater_Ballon;

    [Header("Final Score Area")]
    [SerializeField] private TextMeshProUGUI finalScore;
    [SerializeField] private TextMeshProUGUI suggestionArea;
    float scoreValue;


    [Header("Tutorial Objects")]
    // for tracking what tutorial is being shown
    private bool[] _tutorialSteps = new bool[20];
    [SerializeField] private GameObject[] tutorials;


    [Header("Errors Tracking")]
    private static int _all_Errors;
    public static int AllErrors
    {
        get { return _all_Errors; }
        set { _all_Errors = value; }
    }



    // errors 
    private List<string> errorPoints = new List<string>();
    public List<string> ErrorPoints
    {
        get { return errorPoints; }
        set { errorPoints = value; }
    }
    
    bool[] steps = new bool[18];

    private void Start()
    {
        _stages = stages.ONE;
        setFalseAll();
        setTutorialsFalse();
        surgeryInstructions = GetComponent<surgeryInstructions>();
        
       // percentageHolder = 0.3f;
       // percentageText = "50";
    }

    private void Update()
    {
        checkStates();
        _ui_Updates();
    }

    void checkStates()
    {

        switch (_stages)
        {
            case stages.ONE:
                //disable all line Renderers
                UpdateProgressShow(5, 0.01f);
              
                break;
            case stages.TWO:
                // Debug.Log("Ante second stage entered ");
                UpdateProgressShow(10, 0.1f);
                break;
            case stages.THREE:
                UpdateProgressShow(15, 0.2f);
                // Debug.Log("Ante third stage entered ");
                StartCoroutine(changeBloodBagColor());

                // stop syring from being movable
                Syring_Grabble.TransferOnSecondSelection = false;
                break;
            case stages.FOUR:
                UpdateProgressShow(20, 0.25f);
                
                break;
            case stages.FIVE:
                UpdateProgressShow(25, 0.3f);

                // stop slider from being move after allowed at this level
                _inserter_Grabbable.TransferOnSecondSelection = false;

                _wire_renderer[0].enabled = true;
                break;
            case stages.SIX:
                UpdateProgressShow(30, 0.35f);
                break;
            case stages.SEVEN:
                UpdateProgressShow(35, 0.4f);
                

                surgeryInstructions.testCall();

                // changes here are from the slider in trackPush
                break;
            case stages.EIGHT:
                UpdateProgressShow( 40 , 0.45f);
                break;
            case stages.NINE:
                UpdateProgressShow(45, 0.5f);
                // here the blood bag was taken out


                break;
            case stages.TEN:
                UpdateProgressShow(50, 0.55f);
                // this is when the tube wire (yellow tube wire)  is added and slided down
                //changing the lineRenderer color to yellow
                _wire_renderer[1].startColor = Color.yellow;
                _wire_renderer[1].endColor = Color.yellow;


                break;
            case stages.ELEVEN:
                // here the dye bag is added for the tumor to be identified

                Invoke("reduceDyeBagSize", 3.0f);
                Invoke("showTumorVisible", 4.0f);
                UpdateProgressShow(55, 0.6f);
               

                break;
            case stages.TWELVE:
                UpdateProgressShow(60, 0.65f);
                // here the user moved forward to the screen
                break;
            case stages.THIRTEEN:
                // dye tube is removed
                UpdateProgressShow(65, 0.7f);


                break;
            case stages.FOURTEEN:
                // mesh tube added
                UpdateProgressShow(70, 0.75f);

                // change color of renderer to indicate new string added
                _wire_renderer[1].startColor = Color.white;
                _wire_renderer[1].endColor = Color.white;

                break;
            case stages.FIFTEEN:
                //mesh tube slided in
                UpdateProgressShow(80, 0.80f);
                _tumor_Left.SetActive(false);
                _tumor_Right.SetActive(false);

                break;
            case stages.SIXTEEN:
                // mesh tube slided out
                UpdateProgressShow(85, 0.85f);
                break;
            case stages.SEVENTEEN:
                // make the other object pickable
                _inserter_Grabbable.TransferOnSecondSelection = true;
                Syring_Grabble.TransferOnSecondSelection = true;

                UpdateProgressShow(90, 0.90f);
                break;
            case stages.EIGHTTEEN:
                
                UpdateProgressShow(95, 0.95f);
                break;
            case stages.NINETEEN:
                UpdateProgressShow(100, 1.0f);

                break;
            default:
                break;
        }
    }


    //updates the final score board after the surgery is overs
    public void updateFinalScore()
    {
        string finalContent = "";

        if(scoreValue > 50)
        {
            finalScore.text = "<color=yellow> SCORE: </color> <b><color=green>" + scoreValue + "</color></b> \n <color=red> ERRORS: " + _all_Errors + "</color>\n";

        }
        else
        {
            finalScore.text = "<color=yellow> SCORE: </color> <b><color=red>" + scoreValue + "</color></b> \n <color=red> ERRORS: " + _all_Errors + "</color> \n";
        }
        
        // here, we go through a list of suggestions and add for now no list since no
        // error tracking added yet. 
        if(errorPoints.Count > 0)
        {
            foreach(var errorPoint in errorPoints)
            {
                finalContent += "<color=green> " + errorPoint + " </color> \n";
            }
        }

        suggestionArea.text = finalContent;
    }

    //change color of heart artery to see the tumor in the heart

    void showTumorVisible()
    {
        if(_HeartArtery_Material != null)
        {
            previous_ArteryMaterial = _HeartArtery.GetComponent<MeshRenderer>().material;
            _HeartArtery.GetComponent<MeshRenderer>().material = _HeartArtery_Material;
        }    
    }

    //change the heart artery to the normal color difficult to see the tumor
    /*
    void showTumorNotClear()
    {
        if(previous_ArteryMaterial != null)
        {
            _HeartArtery.GetComponent<MeshRenderer>().material = previous_ArteryMaterial;
        }
        
    }*/

    // enable or disable mesh baloon
    public void enableBallon(bool value)
    {
        _inflater_Ballon.SetActive(value);
    }


    // change the color of the bag to red 
    IEnumerator changeBloodBagColor()
    {
        yield return new WaitForSeconds(4.0f);
        _BloodBag.GetComponent<MeshRenderer>().material = _BloodBag_Material;
        _BloodBag.transform.localScale = new Vector3(7.75f, 9.9f, _BloodBag.transform.localScale.z);

    }
    
    // increase bag size again when wire pieces heart. 
    public void increaseBloodBagSize()
    {
        _BloodBag.transform.localScale = new Vector3(7.8f, 10.0f, _BloodBag.transform.localScale.z);
    }

    // reduce size of dye bag after its added
    void reduceDyeBagSize()
    {
        _DyeBag.transform.localScale = new Vector3(4.67f, 5.7f, _DyeBag.transform.localScale.z);
    }

    public void checkingStageTwelve()
    {
        if (steps[7] == true && steps[8] == false)
        {
            _stages = stages.TWELVE;
            steps[8] = true;
        }
    }

    void getLineRenderers()
    {
        foreach (GameObject wir in _wires)
        {
            if (wir != null)
            {
                _wire_renderer.Add(wir.GetComponent<LineRenderer>());

            }
        }

    }

    //update the persent progress made. 
    void UpdateProgressShow(int amount, float roundamount)
    {
        // set percentage complete
        scoreValue = amount;
        percentageText = "" + amount + "%";
        // Debug.Log(" Update Progress Changed ");

        //set image percentage
        percentageHolder = roundamount;
        

    }
    
    void _ui_Updates()
    {
        //set percentage complete
        
        percentageProgress.text = percentageText;
        //set image percentage
        percentageImage.fillAmount = percentageHolder;

    }

    // singleton pattern
    private void Awake()
    {
        getLineRenderers();

        // If there is an instance, and it's not me, delete myself
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void changeState(stages state)
    {
        _stages = state;
    }

    public stages getChangeState()
    {
        return _stages;
    }

    void setFalseAll()
    {
        for(int i = 0; i < steps.Length; i++)
        {
            steps[i] = false;
        }

       
    }

    public bool getStepState(int index)
    {
        return steps[index];
    }

    public void setStepState(bool value, int index)
    {
        steps[index] = value;
    }

    // some scene management
    public void exitScene()
    {
        StartCoroutine(exitSceneWait());
    }

    public void reloadScene()
    {
        StartCoroutine(reloadSceneWait());
    }

    IEnumerator exitSceneWait()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("hallway");
    }

    IEnumerator reloadSceneWait()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("surgery");
    }

    // increase the errors
    public void increaseErrors()
    {
        _all_Errors += 1;
    }

    // add an instruction to the list
    public void addErrorVibe(string content)
    {
        errorPoints.Add(content);  
    }

    // changing tutorials steps by setting a value
    public void setTutorialStep(bool value, int index)
    {
        _tutorialSteps[index] = value;
        updateTutorialsPoints();
    }

    // getting tutorials stesp value
    public bool getTutorialStep(int index)
    {
        return _tutorialSteps[index];
    }


    // setting all tutorials to false
    public void setTutorialsFalse()
    {
        for (int i = 0; i < _tutorialSteps.Length; i++)
        {
            _tutorialSteps[i] = false;
        }
    }


    // update showing instructions
    private void updateTutorialsPoints()
    {        
        for(int i = 0; i < tutorials.Length; i++)
        {
            tutorials[i].SetActive(_tutorialSteps[i]);
        }
    }
}
