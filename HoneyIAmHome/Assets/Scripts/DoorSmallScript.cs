using UnityEngine;

public class DoorSmallScript : MonoBehaviour
{
    public Animator animator;
    public string parameterName;
    private AudioSource aSource;

    public AudioClip doorOpen;
    public AudioClip doorClose;

    void Start()
    {
        aSource = GetComponentInParent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool(parameterName, true);
        aSource.PlayOneShot(doorOpen);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool(parameterName, false);
        aSource.PlayOneShot(doorClose);
    }
}
