using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherScript : ObjectGrabbingScript
{
    public override void InteractWith(ObjectInteractionScript interactableObject)
    {
        interactableObject.InteractWithFireExtinguisher();
    }
}
