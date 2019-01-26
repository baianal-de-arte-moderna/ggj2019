using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveInteractionScript : ObjectInteractionScript
{
    public override void InteractByItself()
    {
        Debug.Log("Interacting with the stove!");
    }

    public override void InteractWithFireExtinguisher()
    {
        SolveIssue();
    }

    public override void InteractWithToolbox()
    {
        Debug.Log("Interacting with the stove with the toolbox!");
    }
}
