using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapBackToPosition : MonoBehaviour
{
    [SerializeField] private float returnTimer;
    private Vector3 _initialPosition;
    private Quaternion _initialRotation;
    private Vector3 _initialScale;

    private TwoGrabFreeTransformer[] _freeTransformers;
    private Rigidbody _rigidBody;

    private bool canStart = false;

    public void returnBack()
    {

        timerReturn();
     
        
    }

  





    void timerReturn()
    {

       

        transform.position = _initialPosition;
        transform.rotation = _initialRotation;
        transform.localScale = _initialScale;

        if (_rigidBody)
        {
            _rigidBody.velocity = Vector3.zero;
            _rigidBody.angularVelocity = Vector3.zero;
        }

        foreach (var freeTransformer in _freeTransformers)
        {
            freeTransformer.MarkAsBaseScale();
        }

    }

    protected virtual void OnEnable()
    {
        _initialPosition = transform.position;
        _initialRotation = transform.rotation;
        _initialScale = transform.localScale;
        _freeTransformers = GetComponents<TwoGrabFreeTransformer>();
        _rigidBody = GetComponent<Rigidbody>();
    }
}
    

