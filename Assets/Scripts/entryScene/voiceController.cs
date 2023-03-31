using Meta.WitAi.Json;
using Meta.WitAi;
using Oculus.Voice;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Oculus.Interaction.Samples;

public class voiceController : MonoBehaviour
{
    [Header("Scene Script Reference")]
    [Tooltip("Use to control Scene Loading")]
    [SerializeField] private SceneLoader loader;

    [Header("Canvas Fading")]
    [Tooltip("Use for fading out the canvas when scene is loading out")]
    [SerializeField] private fading fade;

    [Header("Display")]
    [Tooltip("Show what is being said")]
    [SerializeField] private TextMeshProUGUI showText;
    


   
    /*
    private void OnEnable()
    {
        appVoiceExperience.events.OnFullTranscription.AddListener(OnRequestTranscript);
    }

    private void OnDisable()
    {
        appVoiceExperience.events.OnFullTranscription.RemoveListener(OnRequestTranscript);
    }
    */

    public void StartSimulation()
    {
        Debug.Log("Ante the change simulation is working ");
        fade.fadeOut();
        loader.Load("hallway");
    
    }

    /*
    private void OnRequestTranscript(string transcript)
    {
        showText.text = transcript;
    }
    */

   
    [Header("Voice")]
    [SerializeField] private AppVoiceExperience appVoiceExperience;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetActivation();
        }
    }



    // Set activation
    void  SetActivation()
    {
        appVoiceExperience.Activate();
    }

}
