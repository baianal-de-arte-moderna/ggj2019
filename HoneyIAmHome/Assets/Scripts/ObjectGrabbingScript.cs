using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectGrabbingScript : MonoBehaviour
{
    FixedJoint joint;

    void Start() {
        this.joint = null;
    }

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
    
    public void AttachTo(Rigidbody r) {
        if (r == null) {
            Destroy(this.joint);
            this.joint = null;
        } else {
            this.joint = gameObject.AddComponent<FixedJoint>();
            this.joint.connectedBody = r;
            this.joint.connectedMassScale = 0.25f;
        }
    }

    abstract public void InteractWith(ObjectInteractionScript interactableObject);
}
