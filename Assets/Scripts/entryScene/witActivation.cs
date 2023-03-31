using Oculus.Voice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witActivation : MonoBehaviour
{
    private AppVoiceExperience _voiceExperience;
    private void OnValidate()
    {
        if (!_voiceExperience) _voiceExperience = GetComponent<AppVoiceExperience>();
    }

    private void Start()
    {
        _voiceExperience = GetComponent<AppVoiceExperience>();
        if( _voiceExperience != null)
        {
            ActivateWit();
        }
    }

    private void Update()
    {
        
    }

    /// <summary>
    /// Activates Wit i.e. start listening to the user.
    /// </summary>
    public void ActivateWit()
    {
        _voiceExperience.Activate();
    }
}
