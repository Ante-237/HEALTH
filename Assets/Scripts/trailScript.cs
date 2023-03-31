using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailScript : MonoBehaviour
{
    public TrailRenderer _lineRenderer;
    private float lengthOfLineRenderer = 10;

    private void Start()
    {
        _lineRenderer = GetComponent<TrailRenderer>();

    }

    private void Update()
    {
        var t = Time.time;
        for (int i = 0; i < lengthOfLineRenderer; i++)
        {
            _lineRenderer.SetPosition(i, new Vector3(0.0f, Mathf.Sin((i + t) * 2), i * 0.001f));
        }
    }
}
