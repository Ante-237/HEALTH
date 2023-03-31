using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followLine : MonoBehaviour
{
    public List<Transform> points = new List<Transform>();
    public LineRenderer _lineRenderer;

    //private int pointsCount;
    //private int _startPoint = 0;


    private float timeGap = 1.0f;
    private float normalTime = 0.0f;



    int startCount = 1;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.useWorldSpace = false;
        _lineRenderer.positionCount = points.Count;
        
    }


    private void Update()
    {
      //  changeOverTime();
    }


    void changeOverTime()
    {
        if(Time.time > normalTime)
        {
            // run code
            runnerUp();
            normalTime = Time.time + timeGap;
          
        }
    }

    /*
    IEnumerator moveToNext()
    {
        yield return new WaitForSeconds(3.0f);
        if(_startPoint < pointsCount)
        {
            _lineRenderer.SetPosition(_startPoint, points[_startPoint].position);
            _startPoint += 1;
        }
    }
    */

    // increase count number by one and add the next point.


    public void runnerUp()
    {
        //increase counter
        if(startCount < points.Count)
        {
            _lineRenderer.SetPosition(startCount, points[startCount - 1].localPosition);
            startCount += 1;
        }
      
    }



}
