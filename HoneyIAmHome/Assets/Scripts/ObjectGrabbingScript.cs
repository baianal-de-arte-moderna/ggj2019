using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectGrabbingScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInteractionScript player = other.gameObject.GetComponent<PlayerInteractionScript>();
        player.OnGrabbableObjectTriggerEnter(this);
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInteractionScript player = other.gameObject.GetComponent<PlayerInteractionScript>();
        player.OnGrabbableObjectTriggerExit(this);
    }
}
