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

    abstract public void InteractByItself();
    
    abstract public void InteractWithFireExtinguisher();
}
