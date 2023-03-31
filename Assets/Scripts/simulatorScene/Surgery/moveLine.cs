using Oculus.Platform.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLine : MonoBehaviour
{
    [SerializeField] private Transform[] points;

    [SerializeField] private LineRenderer _lineRenderer;
    [SerializeField] private trackPush trackPush;
    // Start is called before the first frame update

    // timeGap = 2.0f;
    // float originalTime = 0.0f;

    [SerializeField] private int lineDistance = 4;
    
    void Start()
    {
        //DrawLine();
        // get size from trackPush script
        lineDistance = trackPush.getSize();

    }

    // Update is called once per frame
    void Update()
    {
         DrawLine();
        // changeInTime();
    }

    void DrawLine()
    {
        lineDistance = trackPush.getSize();
        _lineRenderer.positionCount = lineDistance;
        for (int i = 0; i < lineDistance; i++)
        {
            _lineRenderer.SetPosition(i, points[i].position);
        }
    }

    /*
    void changeInTime()
    {
        if(Time.time > originalTime)
        {
            if (lineDistance < points.Length)
            {
                originalTime = Time.time + timeGap;
                DrawLine();
                lineDistance += 1;
                // call my functions here
            }
        }
    }
    */
}
