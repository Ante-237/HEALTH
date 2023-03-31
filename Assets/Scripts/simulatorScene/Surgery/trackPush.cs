using UnityEngine;
using System;

public class trackPush : MonoBehaviour
{

    [SerializeField] private GameObject movingObject;
    [SerializeField] private GameObject relativeObject;
    


    private Transform _initial_position;
    // track line going in and out
    bool hasGonein = false;
    bool nextHasGonein = false;

    float overall = 1.6f;
    // size of line renderer
    int _renderer_Size = 1;


    bool firstSlidedown = false;
    bool firstSlideUp = false;

    bool secondslideDown = false;
    bool secondslideUp = false;

    SurgeryManager m;

    
    private void Start()
    {
        _initial_position = transform;
        m = SurgeryManager.Instance;
    }

    public void FixedUpdate()
    {
        if (m.getStepState(2))
        {
            percentageChange();
        }
          
    }

    /*
    public void currentPosition()
    {
        Debug.Log("ante Current Position of Slider : " + transform.localPosition.y);
        percentageChange();
    }


    public void finalPosition()
    {
        Debug.Log("ante Last Position of Slider : " + transform.localPosition.y);
        percentageChange();
    }
    */

    void percentageChange()
    {

        float data = (float) Math.Round((transform.localPosition.y), 1);
       
        // Debug.Log("Rounded values are : " + data);
        switch (data)
        {
            case -0.9f:
                // if wire has gone in and out, stage seven is set. 
                if (hasGonein)
                {
                    m.changeState(SurgeryManager.stages.SEVEN);
                    sliderStart();
                 
                }

                if(secondslideUp == false && m.getStepState(7) == true)
                {
                    // change only if at the dye level
                    sliderTopWireTwo();
                }

                // change for meshtube out
                if(nextHasGonein && m.getStepState(10) == true)
                {
                    m.changeState(SurgeryManager.stages.SIXTEEN);
                }
                
                _renderer_Size = 1;
                break;
            case -0.8f:
                _renderer_Size = 4;
                break;
            case -0.7f:
                _renderer_Size = 6;
                break;
            case -0.6f:
                _renderer_Size = 7;
                break;
            case -0.5f:
                _renderer_Size = 9;
                break;
            case -0.4f:
                _renderer_Size = 10;
                break;
            case -0.3f:
                _renderer_Size = 11;
                break;
            case -0.2f:
                _renderer_Size = 12;
                break;
            case -0.1f:
                _renderer_Size = 13;
                break;
            case 0.0f:
                m.enableBallon(false);
               
                _renderer_Size = 14;
                break;
            case 0.1f:
                _renderer_Size = 15;
                break;
            case 0.2f:
                _renderer_Size = 16;
                break;
            case 0.3f:
                _renderer_Size = 17;
                break;
            case 0.4f:

                if (m.getStepState(10) == true)
                {
                    _renderer_Size = 20;
                }
                else
                {
                    _renderer_Size = 18;
                }

                break;
            case 0.5f:
                if(m.getStepState(10) == true)
                {
                    _renderer_Size = 23;
                    m.enableBallon(true);
                }
                else
                {
                    _renderer_Size = 19;
                }
                break;
            case 0.6f:
                
                // string arrived the last point  
                if (!hasGonein)
                {
                    m.changeState(SurgeryManager.stages.SIX);
                    hasGonein = true;
                    //increase size of blood bag again
                    m.increaseBloodBagSize();


                    sliderAtEnd();
                    
                }

                // run if dye tube is added and 
                if (secondslideDown == false && (m.getStepState(5) == true))
                {
                 
                    sliderBottomWireTwo();
                }


                //change for mesh tube in 
                if(!nextHasGonein && m.getStepState(10) == true)
                {
                    m.changeState(SurgeryManager.stages.FIFTEEN);
                    nextHasGonein = true;
                    _renderer_Size = 26;
                    m.enableBallon(false);
                }
                else
                {
                    _renderer_Size = 20;
                }
                      
                break;

            default:
                break;
        }
    }

    public int getSize()
    {
        return _renderer_Size;
    }


    // this function is called when the slider meets the end for the first time
    void sliderAtEnd()
    {

        //disble the showing screens for looking at the monitor
        


        // set the tutorial step for slider up. 
        if (!firstSlidedown)
        {
            m.setTutorialStep(true, 10);
            m.setTutorialStep(true, 11);
            m.setTutorialStep(true, 12);
            firstSlidedown = true;
        }
    }

    // this function is called when the slider is back where it started 
    void sliderStart()
    {
        //disable the slider up tutorial 
        m.setTutorialStep(false, 12);


        // enable the look at screen when the slider is done with the sliding. \
        if (!firstSlideUp)
        {
            m.setTutorialStep(false, 10);
            m.setTutorialStep(false, 11);
            m.setTutorialStep(true, 13);
            firstSlideUp = true;
        }

    }


    // this is called when the wire for black dye is added into the body 
    // and slided to the bottom. 
    void sliderBottomWireTwo()
    {
        if (!secondslideDown)
        {
            m.setTutorialStep(false, 9);
            // show for picking up the dye bag to be added. 
            m.setTutorialStep(true, 16);
            secondslideDown = true;
        }
    }   



    // this is called when the slider goes upwards back
    // taking out string showing.
    void sliderTopWireTwo()
    {
        if (!secondslideUp)
        {
            m.setTutorialStep(false, 12);
            m.setTutorialStep(true, 13);

            secondslideUp = true;   
        }
    }
}
