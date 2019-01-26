using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    private ObjectGrabbingScript nearestGrabbableObject;
    private ObjectGrabbingScript grabbedObject;

    private void Update()
    {
        if (Input.anyKeyDown && Input.GetAxis("Grab") > 0f)
        {
            if (grabbedObject != null)
            {
                grabbedObject.transform.parent = transform.parent;
                grabbedObject = null;
            }
            else if (nearestGrabbableObject != null)
            {
                grabbedObject = nearestGrabbableObject;
                grabbedObject.transform.parent = transform;
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
}
