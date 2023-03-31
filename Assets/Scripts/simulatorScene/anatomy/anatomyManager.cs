using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anatomyManager : MonoBehaviour
{

    public static anatomyManager Instance { get; private set; }






    // singleton pattern
    private void Awake()
    {
        

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


}
