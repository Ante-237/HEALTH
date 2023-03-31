using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveAnatomyRoom : MonoBehaviour
{



    // use the wrapper events
    public void transitionScene()
    {
        StartCoroutine(changeScene());
    }

    // calling the scene in loading progress. 
    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("entryScene");
    }
}
