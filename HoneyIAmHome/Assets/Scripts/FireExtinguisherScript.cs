using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherScript : InteractableObjectScript
{
    public override void Interact()
    {
        Debug.Log("Fire extinguished!");
    }
}
