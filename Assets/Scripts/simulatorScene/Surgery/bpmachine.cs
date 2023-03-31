using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bpmachine : MonoBehaviour
{
    [Range(0, 100)]
    [SerializeField] private int bloodPressure = 50;
    private float pdChangeSpeed = 2.0f;

    [Header("Text Show")]
    [SerializeField] private TextMeshProUGUI _pbText;
    [SerializeField] private lineRenderer _lineRenderer;
    private int currentpb;


    [Header(" mmHg Display")]
    [SerializeField] private TextMeshProUGUI _nextpbText;
    [SerializeField] private TextMeshProUGUI _nextsecondText;
    [Range(60, 80)]
    [SerializeField] private int nextOnePressure = 70;
    [Range(100, 140)]
    [SerializeField] private int nextTwoPressure = 101;


    [Header(" Water Level ")]
    [SerializeField] private TextMeshProUGUI _waterText;
    [Range(30, 60)]
    [SerializeField] private int waterPressure = 40;


    [Header(" Last Level")]
    [SerializeField] private TextMeshProUGUI _lastText;
    [Range(15, 30)]
    [SerializeField] private int lastPressure = 26;

    // time gap changing

    private float timeGap = 0.5f;
    private float nextGap = 5.0f;
    private float nextCurrentGap = 0;
    private float currentTime = 0;

    private void Update()
    {
        //InvokeRepeating("updatePd", 1.5f, pdChangeSpeed);
        ChangingTiming();
    }


    private void ChangingTiming()
    {
        if(Time.time > currentTime)
        {
            currentTime = Time.time + timeGap;
            StartCoroutine(changingNow());
            StartCoroutine(changingNowTwo());
        }
    }

    public void updatePd()
    {
        // update states only when pd changes.
        // updateLineRenderer();
        if(bloodPressure >  100)
        {
            bloodPressure -= 1;
            _pbText.text = bloodPressure.ToString();
        }
        
        if(bloodPressure > 50 && bloodPressure < 101) 
        { 
            bloodPressure += 1;
            _pbText.text = bloodPressure.ToString();
        }

        if(Time.time > nextCurrentGap)
        {
            nextCurrentGap = Time.time + nextGap;
            bloodPressure = Random.Range(50, 100);
            nextOnePressure = Random.Range(60, 80);
            nextTwoPressure = Random.Range(100, 140);
            waterPressure = Random.Range(30, 60);
            lastPressure = Random.Range(15, 30);

        }


        // _nextpb chaning
        if (nextOnePressure > 80)
        {
            nextOnePressure -= 1;
            _nextpbText.text = nextOnePressure.ToString();

        }

        if (nextOnePressure > 60 && nextOnePressure < 80)
        {
            nextOnePressure += 1;
            _nextpbText.text = nextOnePressure.ToString();
        }


        // nextTwoPressure show
        if (nextTwoPressure > 140)
        {
            nextTwoPressure -= 1;
            _nextsecondText.text = nextTwoPressure.ToString();

        }

        if (nextTwoPressure > 100 && nextTwoPressure < 140)
        {
            nextTwoPressure += 1;
            _nextsecondText.text = nextTwoPressure.ToString();
        }



    }

    public void secondUpdatePd()
    {
        if (waterPressure > 60)
        {
            waterPressure -= 1;
            _waterText.text = waterPressure.ToString();

        }

        if (waterPressure > 30 && waterPressure < 60)
        {
            waterPressure += 1;
            _waterText.text = waterPressure.ToString();
        }

        if (lastPressure > 30)
        {
            lastPressure -= 1;
            _lastText.text = lastPressure.ToString();

        }

        if (lastPressure > 15 && lastPressure < 30)
        {
            lastPressure += 1;
            _lastText.text = lastPressure.ToString();
        }

    }


    // waiting timegap for channging
    IEnumerator changingNow()
    {
        yield return new WaitForSeconds(3.0f);
        updatePd();
    }

    // another time changer but in different way
    IEnumerator changingNowTwo()
    {
        yield return new WaitForSeconds(5.0f);
        secondUpdatePd();

    }




}
