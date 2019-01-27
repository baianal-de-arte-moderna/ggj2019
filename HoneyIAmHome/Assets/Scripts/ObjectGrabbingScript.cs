using UnityEngine;

public abstract class ObjectGrabbingScript : MonoBehaviour
{
    private new Rigidbody rigidbody;
    private Transform rootTransform;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        rootTransform = transform.parent;
        while (rootTransform.parent != null)
        {
            rootTransform = rootTransform.parent;
        }
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

    public void AttachTo(Rigidbody otherRigidBody)
    {

        if (otherRigidBody == null)
        {
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
            rootTransform.parent = null;
        }
        else
        {
            rigidbody.isKinematic = true;
            rigidbody.useGravity = false;
            rootTransform.parent = otherRigidBody.transform;
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
