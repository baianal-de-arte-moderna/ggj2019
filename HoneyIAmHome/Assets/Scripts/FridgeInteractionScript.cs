using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeInteractionScript : ObjectInteractionScript
{
    public override void InteractByItself()
    {
        SolveIssue(); 
    }

    public override void InteractWithFireExtinguisher()
    {
        Debug.Log("Interacting with the frige with the fire extinguisher!");
    }

    public override void InteractWithIrrigator()
    {
        Debug.Log("Interacting with the frige with the irrigator!");
    }

    public override void InteractWithToolbox()
    {
        Debug.Log("Interacting with the fridge with the toolbox!");
    }
}
