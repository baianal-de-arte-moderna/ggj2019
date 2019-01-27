using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherScript : ObjectGrabbingScript
{
    public ParticleSystem foam;

    public override void InteractWith(ObjectInteractionScript interactableObject)
    {
        interactableObject.InteractWithFireExtinguisher();
    }

    public override void OnInteractionStart()
    {
        base.OnInteractionStart();
        Debug.Log("Start foaming!");
        foam.Play();
    }

    public override void OnInteractionEnd()
    {
        base.OnInteractionEnd();
        Debug.Log("Stop foaming!");
        foam.Stop();
    }
}
