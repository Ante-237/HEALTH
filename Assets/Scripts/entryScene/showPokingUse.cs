
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showPokingUse : MonoBehaviour
{
    public GameObject pokeGhostHand;
    public GameObject handshowing;
    private float startGap = 2.0f;
    bool handshow = false;
    bool firstenter = false;



    private void OnTriggerEnter(Collider other)
    {
        handshowing?.SetActive(false);

        if (!firstenter)
        {
            pokeGhostHand.SetActive(true);
            firstenter = true;
            StartCoroutine(closeTutorial());
        }


    }

    private void Update()
    {
        if (Time.time > startGap && handshow == false)
        {
            handshowing.SetActive(true);
            handshow = true;
        }


    }




    IEnumerator closeTutorial()
    {
        yield return new WaitForSeconds(3.0f);
        pokeGhostHand?.SetActive(false);

    }

}
