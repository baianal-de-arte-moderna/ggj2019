using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisherScript : ObjectGrabbingScript
{
    public ParticleSystem foam;
    public AudioSource aSource;
    public AudioClip foamStart;
    public AudioClip foamLoop;

    public override void InteractWith(ObjectInteractionScript interactableObject)
    {
        interactableObject.InteractWithFireExtinguisher();
    }

    public override void OnInteractionStart()
    {
        base.OnInteractionStart();
        aSource.Stop();
        aSource.PlayOneShot(foamStart);
        foam.Play();
        Invoke("StartAudioLoop", foamStart.length);
    }

    public void StartAudioLoop() {
        if (!aSource.isPlaying) 
            aSource.Play();
    }

    public override void OnInteractionEnd()
    {
        base.OnInteractionEnd();
        aSource.Stop();
        foam.Stop();
    }
}
