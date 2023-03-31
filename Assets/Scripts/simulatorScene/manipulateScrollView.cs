using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using Oculus.Interaction;
using static OVRHand;

public class manipulateScrollView : MonoBehaviour
{
    public ControllerColliderHit controller;

    private void Start()
    {
       var hand = GetComponent<OVRHand>();
        bool isIndexFingerPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        float ringFingerPinchStrength = hand.GetFingerPinchStrength(OVRHand.HandFinger.Ring);
        TrackingConfidence confidence = hand.GetFingerConfidence(OVRHand.HandFinger.Index);
        float scalehand = hand.HandScale;

    }
}
