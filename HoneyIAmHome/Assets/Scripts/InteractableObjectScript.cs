using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObjectScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInteractionScript player = other.gameObject.GetComponent<PlayerInteractionScript>();
        player.OnInteractableObjectTriggerEnter(this);
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInteractionScript player = other.gameObject.GetComponent<PlayerInteractionScript>();
        player.OnInteractableObjectTriggerExit(this);
    }

    abstract public void Interact();
}
