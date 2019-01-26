using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkInteractionScript : ObjectInteractionScript
{
    public override void InteractByItself()
    {
        Debug.Log("Interacting with the sink!");
    }

    public override void InteractWithFireExtinguisher()
    {
        Debug.Log("Interacting with the sink with the fire extinguisher!");
    }

    public override void InteractWithToolbox()
    {
        SolveIssue();
    }
}
