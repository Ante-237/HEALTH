using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using UnityEngine.UIElements;

public class showAnatomy : MonoBehaviour
{
    [SerializeField] private GameObject ObjectToShow;
    [SerializeField] private TextMeshPro textMeshPro;

    static readonly string[] s_ShowAnatomyNames = new string[] { "SHOW", "HIDE" };

    public List<GameObject> anatomyParts = new List<GameObject>();

    public float pauseTime = 0.3f;
    public bool stopRoutine = false;




    private bool isShow = false;
    private int countState = 0;


    public void Update()
    {
        // will stop the coroutine after it runs completely
        if (stopRoutine)
        {
            StopCoroutine(showParts());
            stopRoutine = false;
        }
    }


    public void changeState()
    {
        if (!isShow)
        {
            isShow = true;
            textMeshPro.text = s_ShowAnatomyNames[1];
           // ObjectToShow.SetActive(isShow);
            StartCoroutine(showParts());
        }
        else
        {
            isShow = false;
            textMeshPro.text = s_ShowAnatomyNames[0];
            StartCoroutine(showParts());
           // ObjectToShow.SetActive(false);
            
            
        }
    }

    /*
    void showParts()
    {
        int count = 0;
        for(int i = countState; i < anatomyParts.Count; i++)
        {
            anatomyParts[i].SetActive(isShow);
            count++;
            
            if (count > 5)
            {
                count = 0;
                countState = i;
                break;
            }
        }
    }
    */

    IEnumerator showParts()
    {
        int count = 0;

        for (int i = countState; i < anatomyParts.Count; i++)
        {
            anatomyParts[i].SetActive(isShow);
            count++;

            if (count > 5)
            {
                count = 0;
                yield return new WaitForSeconds(pauseTime);
            }
        }

        stopRoutine = true;

    }
}
