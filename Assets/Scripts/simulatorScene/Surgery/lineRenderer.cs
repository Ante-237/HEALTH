using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRenderer : MonoBehaviour
{
    public LineRenderer _lineRenderer;
    // private float lengthOfLineRenderer = 100;

    public int points;
    public float amplitude = 0.001f;
    public Vector2 xLimits = new Vector2(0, 1);
    public float frequency = 1.0f;
 
    public float movementSpeed = 2.0f;
    




    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();

    }

    void Draw()
    {
        float xStart = 0;
        float Tau = 2 * Mathf.PI;
        float xFinish = xLimits.y;


        _lineRenderer.positionCount = points;

        for(int currentPoint = 0; currentPoint < points; currentPoint++)
        {
            float progress = (float)currentPoint/(points-1);
            float x = Mathf.Lerp(xStart, xFinish, progress);
            float y = amplitude * Mathf.Sin((Tau * frequency *x) + Time.timeSinceLevelLoad * movementSpeed);
            _lineRenderer.SetPosition(currentPoint, new Vector3(x, y, 0));
        }
    }

    private void Update()
    {
        Draw();
    }
}
