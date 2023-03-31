using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingScript : MonoBehaviour
{
    private Renderer myRenderer;
 
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    public static class Logging
    {
        [System.Diagnostics.Conditional("ENABLE_LOG")]
        static public void Log(object message)
        {
            Debug.Log(message);
        }
    }

#if UNITY_EDITOR
    void Update()
    {
        
    }
#endif
}
