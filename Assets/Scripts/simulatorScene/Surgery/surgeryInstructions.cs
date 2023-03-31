using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class surgeryInstructions : MonoBehaviour
{

    SurgeryManager m;

    public TextMeshProUGUI[] instructionText;
    public Image[] instructionsImages;



    public Sprite[] rawImages;


    private Dictionary<string, string> instructionDict = new Dictionary<string, string>();


    bool[] _thePass = new bool[20];


    bool[] set_steps = new bool[10];

    private void Start()
    {
        m = SurgeryManager.Instance;
        // setup dictionary content
        setupDictionary();

        // first steps can go on
        set_steps[0] = true;
    }

    private void Update()
    {
        switcher();
    }

    void InstructionsOne()
    {
        if (SurgeryManager.stages.ONE == m._stages && _thePass[0] == false)
        {
            instructionText[0].text = instructionDict["one"];
            instructionText[1].text = instructionDict["two"];
            instructionText[2].text = instructionDict["three"];

            instructionsImages[0].sprite = rawImages[1];
            instructionsImages[1].sprite = rawImages[2];
            instructionsImages[2].sprite = rawImages[2];
            _thePass[0] = true;
        }
        else if (SurgeryManager.stages.TWO == m._stages && _thePass[0] == true)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[1];
            instructionsImages[2].sprite = rawImages[2];
            _thePass[1] = true;

        }
        else if (SurgeryManager.stages.THREE == m._stages && _thePass[1] == true)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[1];
            _thePass[2] = true;
        }
        else if (SurgeryManager.stages.FOUR == m._stages && _thePass[2] == true)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[0];
            _thePass[3] = true;
            set_steps[0] = false;
            set_steps[1] = true;
            StartCoroutine(setForNextInstructions("four", "five", "six"));
            //setForNextInstructions("four", "five", "six");
        }
    }

    // forward for next instructions set. 
    void InstructionsTwo()
    {
        if (SurgeryManager.stages.FIVE == m._stages && _thePass[4] == false)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[1];
            instructionsImages[2].sprite = rawImages[2];
            _thePass[5] = true;
        }
        else if (SurgeryManager.stages.SIX == m._stages && _thePass[5] == true)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[1];
            _thePass[6] = true;
        }

        else if (SurgeryManager.stages.SEVEN == m._stages && _thePass[6] == true)
        {
            
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[0];
            _thePass[6] = false;
            set_steps[1] = false;
            set_steps[2] = true;
            StopCoroutine(setForNextInstructions("four", "five", "six"));
            StartCoroutine(setForNextInstructions("seven", "eight", "nine"));
            //setForNextInstructions("seven", "eight", "nine");
        }
    }


    // calling for seven in surgery manager manually since call sequence issues
    public void testCall()
    {
        if (_thePass[7] == false)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[0];
            _thePass[7] = true;
            StopCoroutine(setForNextInstructions("four", "five", "six"));
            StartCoroutine(setForNextInstructions("seven", "eight", "nine"));
        }
       
    }


    void InstructionsThree()
    {
        if (SurgeryManager.stages.EIGHT == m._stages && _thePass[7] == true)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[1];
            instructionsImages[2].sprite = rawImages[2];
            _thePass[8] = true;
        }
        else if (SurgeryManager.stages.NINE == m._stages && _thePass[8] == true)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[1];
            _thePass[9] = true;
        }
        else if (SurgeryManager.stages.TEN == m._stages && _thePass[9] == true)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[0];
            _thePass[10] = true;
            //_thePass[7] = false;
            set_steps[2] = false;
            set_steps[3] = true;
            StopCoroutine(setForNextInstructions("seven", "eight", "nine"));
            StartCoroutine(setForNextInstructions("ten", "eleven", "twelve"));
           // setForNextInstructions("ten", "eleven", "twelve");
        }
    }


    void InstructionsFour()
    {
        if (SurgeryManager.stages.ELEVEN == m._stages && _thePass[10] == true)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[1];
            instructionsImages[2].sprite = rawImages[2];
            _thePass[11] = true;
        }
        else if (SurgeryManager.stages.TWELVE == m._stages && _thePass[11] == true)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[1];
            _thePass[12] = true;
        }
        else if (SurgeryManager.stages.THIRTEEN == m._stages && _thePass[12] == true)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[0];
            _thePass[13] = true;
            set_steps[3] = false;
            set_steps[4] = true;
            StopCoroutine(setForNextInstructions("ten", "eleven", "twelve"));
            StartCoroutine(setForNextInstructions("thirteen", "fourteen", "fifteen"));
            // setForNextInstructions("ten", "eleven", "twelve");
        }
    }



    void InstructionFive()
    {
        if (SurgeryManager.stages.FOURTEEN == m._stages && _thePass[13] == true)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[1];
            instructionsImages[2].sprite = rawImages[2];
            _thePass[14] = true;
        }
        else if (SurgeryManager.stages.FIFTEEN == m._stages && _thePass[14] == true)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[1];
            _thePass[15] = true;
        }
        else if (SurgeryManager.stages.SIXTEEN == m._stages && _thePass[15] == true)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[0];
            _thePass[16] = true;
            set_steps[4] = false;
            set_steps[5] = true;
            StopCoroutine(setForNextInstructions("thirteen", "fourteen", "fifteen"));
            StartCoroutine(setForNextInstructions("sixteen", "seventeen", "eighteen"));
            // setForNextInstructions("ten", "eleven", "twelve");
        }
    }

    void InstructionSix()
    {
        if (SurgeryManager.stages.SEVENTEEN == m._stages && _thePass[16] == true)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[1];
            instructionsImages[2].sprite = rawImages[2];
            _thePass[17] = true;
        }
        else if (SurgeryManager.stages.EIGHTTEEN == m._stages && _thePass[17] == true)
        {
            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[1];
            _thePass[18] = true;
        }
        else if (SurgeryManager.stages.NINETEEN == m._stages && _thePass[18] == true)
        {

            instructionsImages[0].sprite = rawImages[0];
            instructionsImages[1].sprite = rawImages[0];
            instructionsImages[2].sprite = rawImages[0];
            StopCoroutine(setForNextInstructions("sixteen", "seventeen", "eighteen"));
            //StartCoroutine(setForNextInstructions("sixteen", "seventeen", "eighteen"));
            // setForNextInstructions("ten", "eleven", "twelve");
        }
    }

    void switcher()
    {
        if (set_steps[0])
        {
            // next set if the last instruction pass is false
            InstructionsOne();
        }
        else if (set_steps[1])
        {
            // next set if the last instruction of next set is false
            InstructionsTwo();

        }
        else if (set_steps[2])
        {

            // next set if the last instruction of next set is true
            
            InstructionsThree();
        }
        else if (set_steps[3])
        {
            // calling for next steps
             InstructionsFour();
        }
        else if (set_steps[4])
        {
            InstructionFive();
        }
        else if (set_steps[5])
        {
            InstructionSix();
        }

    }

        // call for instruction set two text set/
        
        IEnumerator setForNextInstructions(string one, string two, string three)
        {
            yield return new WaitForSeconds(2.0f);
            instructionsImages[0].sprite = rawImages[1];
            instructionsImages[1].sprite = rawImages[2];
            instructionsImages[2].sprite = rawImages[2];
            instructionText[0].text = instructionDict[one];
            instructionText[1].text = instructionDict[two];
            instructionText[2].text = instructionDict[three];

        }
        

    /*
        void setForNextInstructions(string one, string two, string three)
        {
         
            instructionsImages[0].sprite = rawImages[1];
            instructionsImages[1].sprite = rawImages[2];
            instructionsImages[2].sprite = rawImages[2];
            instructionText[0].text = instructionDict[one];
            instructionText[1].text = instructionDict[two];
            instructionText[2].text = instructionDict[three];

        }
    */



    void setupDictionary()
        {
            instructionDict.Add("one", "Insert the syring in the exact black spot as seen, any insertion to any of part of the body will lead to damages, be careful, this will take some time.");
            instructionDict.Add("two", "Insert the blood collection bag into the top of the syring, once in the right spot release your hand.");
            instructionDict.Add("three", "Insert the Tube Inserter beside the syring, and release your hands.");

            instructionDict.Add("four", "Pick up the Catheter Tube One and insert into the Tube inserter");
            instructionDict.Add("five", "Use the slider and slide down slowly to insert the Catheter Tube One into the heart section, observe the Screen");
            instructionDict.Add("six", "Pull out the slider slow for the catheter Tube One to be extracted ");

            instructionDict.Add("seven", "Carefully Take out the wire, and place Away, on the table");
            instructionDict.Add("eight", "Take out the blood collection Bag, Place the bag Away, on the table");
            instructionDict.Add("nine", "Pick up the Catheter Tube for  Contrast dye addition,Add to Tube inserter use the slider to slide down and observe the monitor");

            instructionDict.Add("ten", "Slide out the Catheter Tube, Add the dye bag to the end of the syring and observe the monitor ahead of you to identify the tumor point");
            instructionDict.Add("eleven", "Move closer and observe the Monitor Notice the tumor in the artery indicated by a tiny passage when the Contrast dye is added");
            instructionDict.Add("twelve", "Slide the Wire tube out of the Body, then take  it out, since we have identified the point of problem");

            instructionDict.Add("thirteen", "Add the wire tube which contains a mesh tube");
            instructionDict.Add("fourteen", "Used the slider to slide the wire mesh tube down, till a  point where a baloon is inflater in the identified blocked artery.");
            instructionDict.Add("fifteen", "Slide the wire out of the Artery");

            instructionDict.Add("sixteen", "Notice the artery is now open, Move closer to observe");
            instructionDict.Add("seventeen", "Take out the syring slowly and place in former location");
            instructionDict.Add("eighteen", "Practice Prodecure Complete, Proceed the the door to check your  score and where to improve");

            for (int i = 0; i < _thePass.Length; i++)
            {
                _thePass[i] = false;
            }

            for (int i=0; i < set_steps.Length; i++)
            {
                set_steps[i] = false;
             }

        }

    }





