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
            this.joint.connectedMassScale = 0.15f;
            this.joint.connectedBody = r;
        }
    }

    abstract public void InteractWith(ObjectInteractionScript interactableObject);

    public virtual void OnInteractionStart()
    {
        // Do nothing!
    }

    public virtual void OnInteractionEnd()
    {
        // Do nothing!
    }
}
