using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingMachineInteractionScript : ObjectInteractionScript
{
    public override void InteractByItself()
    {
        Debug.Log("Interacting with the washing machine!");
    }

    public override void InteractWithFireExtinguisher()
    {
        Debug.Log("Interacting with the washing machine with the fire extinguisher!");
    }

    public override void InteractWithWatercan()
    {
        Debug.Log("Interacting with the washing machine with the irrigator!");
    }

    public override void InteractWithToolbox()
    {
        SolveIssue();
    }
}
