using UnityEngine;
using System.Collections;

public abstract class ObjectInteractionScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInteractionScript player = other.gameObject.GetComponent<PlayerInteractionScript>();
        if (player)
        { 
            player.OnInteractableObjectTriggerEnter(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInteractionScript player = other.gameObject.GetComponent<PlayerInteractionScript>();
        if (player)
        {
            player.OnInteractableObjectTriggerExit(this);
        }
    }

    protected void SolveIssue()
    {
        ObjectEventScript eventScript = GetComponent<ObjectEventScript>();
        eventScript.SolveIssue();
    }

    abstract public void InteractByItself();
    
    abstract public void InteractWithFireExtinguisher();

    abstract public void InteractWithToolbox();
}
