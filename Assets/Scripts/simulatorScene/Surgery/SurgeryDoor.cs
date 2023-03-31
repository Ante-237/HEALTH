using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurgeryDoor : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Invoke("changeScene", 0.5f);
    }


    void changeScene()
    {
        SceneManager.LoadScene("surgery");
    }

}
