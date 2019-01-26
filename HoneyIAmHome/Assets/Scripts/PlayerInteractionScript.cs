using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    private ObjectGrabbingScript nearestGrabbableObject;
    private ObjectGrabbingScript grabbedObject;

    private ObjectInteractionScript nearestInteractableObject;

    private void Update()
    {
        if (Input.anyKeyDown && Input.GetAxis("Grab") > 0f)
        {
            OnGrabPressed();
        }
        else if (Input.GetAxis("Interact") > 0f)
        {
            OnInteractPressed();
        }
    }

    private void OnGrabPressed()
    {
        if (grabbedObject != null)
        {
            grabbedObject.AttachTo(null);
            grabbedObject = null;
        }
        else if (nearestGrabbableObject != null)
        {
            grabbedObject = nearestGrabbableObject;
            grabbedObject.AttachTo(GetComponent<Rigidbody>());
        }
    }

    private void OnInteractPressed()
    {
        if (nearestInteractableObject != null)
        {
            if (grabbedObject == null)
            {
                nearestInteractableObject.InteractByItself();
            }
            else
            {
                grabbedObject.InteractWith(nearestInteractableObject);
            }
        }
    }

    public void OnGrabbableObjectTriggerEnter(ObjectGrabbingScript grabbableObject)
    {
        nearestGrabbableObject = grabbableObject;
    }

    public void OnGrabbableObjectTriggerExit(ObjectGrabbingScript grabbableObject)
    {
        if (nearestGrabbableObject == grabbableObject)
        {
            nearestGrabbableObject = null;
        }
    }

    public void OnInteractableObjectTriggerEnter(ObjectInteractionScript interactableObject)
    {
        nearestInteractableObject = interactableObject;
    }

    public void OnInteractableObjectTriggerExit(ObjectInteractionScript interactableObject)
    {
        if (nearestInteractableObject == interactableObject)
        {
            nearestInteractableObject = null;
        }
    }
}
