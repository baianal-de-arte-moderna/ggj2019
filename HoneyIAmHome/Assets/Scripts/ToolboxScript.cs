using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolboxScript : ObjectGrabbingScript
{
    public override void InteractWith(ObjectInteractionScript interactableObject)
    {
        interactableObject.InteractWithToolbox();
    }
}
