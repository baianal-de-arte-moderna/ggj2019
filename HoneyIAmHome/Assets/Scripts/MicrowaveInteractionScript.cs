using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrowaveInteractionScript : ObjectInteractionScript
{
    public override void InteractByItself()
    {
        Debug.Log("Interacting with the microwave!");
    }

    public override void InteractWithFireExtinguisher()
    {
        SolveIssue();
    }

    public override void InteractWithWatercan()
    {
        Debug.Log("Interacting with the microwave with the irrigator!");
    }

    public override void InteractWithToolbox()
    {
        Debug.Log("Interacting with the microwave with the toolbox!");
    }
}
