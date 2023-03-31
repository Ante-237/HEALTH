
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Oculus.Interaction.Samples;
using Unity.VisualScripting;

public class switchingScenes : MonoBehaviour
{

    public TextMeshProUGUI headingName;
    public fading fading;
    public SceneLoader sceneLoader;
    private OVRManager ovrManager;


    private void Start()
    {
        ovrManager = OVRManager.instance;
    }

    public void switchScenes()
    {
        checkHeadingName(headingName.text);
    }


    void checkHeadingName(string textName)
    {
        if (textName == "SIMULATOR")
        {
            // fade out
            // launch start scene
            // play fading animtion
            // StartCoroutine(loadSomeScene("hallway"));
            sceneLoader.Load("hallway");
        }

        if (textName == "TUTORIALS")
        {
            // fade out
            // lauch tutorial scene
            // playing fading in animation
            // StartCoroutine(loadSomeScene("tutorialScene"));
            sceneLoader.Load("tutorialScene");
        }

        if (textName == "DEV TEAM")
        {
            // no custom scene for now
        }

        if (textName == "EXIT")
        {
            // exit applications
            quitApplication();

        }
    }


    public void quitApplication()
    {

        if (OVRManager.isHmdPresent)
        {
            OVRPlugin.SendEvent("sdk_quit");
        }
        else
        {
            Application.Quit();
            OnApplicationPause(true);
            
        }
    }


    public void OnApplicationPause(bool pause)
    {
        Application.Quit();
    }


    IEnumerator loadSomeScene(string sceneName)
    {
        fading.fadeOut();
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(sceneName);
    }




}