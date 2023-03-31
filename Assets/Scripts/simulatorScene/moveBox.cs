using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Events;
using Oculus.Interaction.Grab;
using Oculus.Interaction.HandGrab;
using Oculus.Interaction;

public class moveBox : MonoBehaviour, ITransformer, IHandGrabUseDelegate
{

    public IGrabbable grabbable;
    public GameObject someobject;
    [SerializeField]
    private UnityEvent BeginUse;
    [SerializeField]
    private UnityEvent EndUse;


    private void Start()
    {
        grabbable.Transform.position = transform.position;
        grabbable  = transform.GetComponent<Grabbable>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(" The box and the equipment had contact ");
        transform.position += new Vector3(0, 0, 5);
        print(" Game Objec name is : " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        transform.position -= new Vector3(0, 0, 5);
        Debug.LogError(" THE OBJECTS COLLIDED TO BEGIN WITH ");
    }


    public void Initialize(IGrabbable grabbable)
    {
        throw new System.NotImplementedException();
    }

    public void BeginTransform()
    {
        throw new System.NotImplementedException();
    }

    public void UpdateTransform()
    {
        throw new System.NotImplementedException();
    }

    public void EndTransform()
    {
        throw new System.NotImplementedException();
    }

    void IHandGrabUseDelegate.BeginUse()
    {
        throw new System.NotImplementedException();
        // clal method when used 
    }

    void IHandGrabUseDelegate.EndUse()
    {
        throw new System.NotImplementedException();
    }

    public float ComputeUseStrength(float strength)
    {
        throw new System.NotImplementedException();
    }
}
