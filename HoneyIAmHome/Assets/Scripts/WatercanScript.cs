using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatercanScript : ObjectGrabbingScript
{
    public ParticleSystem water;

    public override void InteractWith(ObjectInteractionScript interactableObject)
    {
        interactableObject.InteractWithWatercan();
    }

    public override void OnInteractionStart()
    {
        base.OnInteractionStart();
        water.Play();
    }

    public override void OnInteractionEnd()
    {
        base.OnInteractionEnd();
        water.Stop();
    }
}
