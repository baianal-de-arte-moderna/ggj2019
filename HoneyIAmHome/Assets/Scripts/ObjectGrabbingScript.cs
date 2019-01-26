using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectGrabbingScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInteractionScript player = other.gameObject.GetComponent<PlayerInteractionScript>();
        if (player)
        {
            player.OnGrabbableObjectTriggerEnter(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInteractionScript player = other.gameObject.GetComponent<PlayerInteractionScript>();
        if (player)
        {
            player.OnGrabbableObjectTriggerExit(this);
        }
    }

    abstract public void InteractWith(ObjectInteractionScript interactableObject);
}
