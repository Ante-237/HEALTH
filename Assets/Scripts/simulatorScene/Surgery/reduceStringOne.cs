using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reduceStringOne : MonoBehaviour
{
    [SerializeField] private Vector3 newSize;
    [SerializeField] private Vector3 oldSize;

    public void changeSize()
    {
        transform.localScale = newSize;
    }

    public void OriginalSize()
    {
        transform.localScale = oldSize;
    }
}
