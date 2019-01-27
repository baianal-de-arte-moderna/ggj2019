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

    public override void InteractWithWatercan()
    {
        SolveIssue();
    }

    public override void InteractWithToolbox()
    {
        Debug.Log("Interacting with the plant with the toolbox!");
    }
}
