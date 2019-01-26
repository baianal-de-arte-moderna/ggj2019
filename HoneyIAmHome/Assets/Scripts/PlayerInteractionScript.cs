using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    private InteractableObjectScript nearestInteractableObject;

    private void Update()
    {
        if (Input.GetAxis("Interact") > 0f)
        {
            if (nearestInteractableObject != null)
            {
                nearestInteractableObject.Interact();
            }
        }
    }

    public void OnInteractableObjectTriggerEnter(InteractableObjectScript interactableObject)
    {
        nearestInteractableObject = interactableObject;
    }

    public void OnInteractableObjectTriggerExit(InteractableObjectScript interactableObject)
    {
        if (nearestInteractableObject == interactableObject)
        {
            nearestInteractableObject = null;
        }
    }
}
