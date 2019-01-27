using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsInteractionScript : ObjectInteractionScript
{
    public override void InteractByItself()
    {
        Debug.Log("Interaction with the plant");
    }

    public override void InteractWithFireExtinguisher()
    {
        Debug.Log("The plant is dirty with fire extinguisher powder!");
    }

    public override void InteractWithToolbox()
    {

    }
}
