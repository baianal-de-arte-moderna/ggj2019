using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSmallScript : MonoBehaviour
{
    public Animator animator;
    public string parameterName;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool(parameterName, true);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool(parameterName, false);
    }
}
