using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takingShape : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pathtwo"))
        {
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("pathtwo"))
        {
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
        }
    }



}
