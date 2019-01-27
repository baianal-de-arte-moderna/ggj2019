public class ToolboxScript : ObjectGrabbingScript
{
    public override void InteractWith(ObjectInteractionScript interactableObject)
    {
        interactableObject.InteractWithToolbox();
    }
}
