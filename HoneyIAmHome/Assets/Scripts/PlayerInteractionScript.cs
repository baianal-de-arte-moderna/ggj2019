using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    private ObjectGrabbingScript nearestGrabbableObject;
    private ObjectGrabbingScript grabbedObject;

    private ObjectInteractionScript nearestInteractableObject;

    private bool isInteracting;

    private void Update()
    {
        if (Input.anyKeyDown && Input.GetAxis("Grab") > 0f)
        {
            OnGrabPressed();
        }
        else if (isInteracting)
        {
            if (Input.GetAxis("Interact") <= 0f)
            {
                isInteracting = false;
                OnInteractReleased();
            }
            else
            {
                OnInteractContinued();
            }
        }
        else if (Input.GetAxis("Interact") > 0f)
        {
            isInteracting = true;
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
        if (grabbedObject != null)
        {
            grabbedObject.OnInteractionStart();
            if (nearestInteractableObject != null)
            {
                grabbedObject.InteractWith(nearestInteractableObject);
            }
        }
        else if (nearestInteractableObject != null)
        {
            nearestInteractableObject.InteractByItself();
        }
    }

    private void OnInteractReleased()
    {
        if (grabbedObject != null)
        {
            grabbedObject.OnInteractionEnd();
        }
    }

    private void OnInteractContinued()
    {
        if (grabbedObject != null && nearestInteractableObject != null)
        {
            grabbedObject.InteractWith(nearestInteractableObject);
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
