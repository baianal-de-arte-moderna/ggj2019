using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrrigatorScript : ObjectGrabbingScript
{
    public override void InteractWith(ObjectInteractionScript interactableObject)
    {
        interactableObject.InteractWithIrrigator();
    }
}
