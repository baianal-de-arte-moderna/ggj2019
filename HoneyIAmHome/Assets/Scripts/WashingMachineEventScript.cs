using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingMachineEventScript : ObjectEventScript
{
    public MeshRenderer fixedCover;
    public MeshRenderer brokenCover;
    public Animator doorAnimator;
    
    [Header("Audio Clips")]
    public AudioClip Normal;
    public AudioClip Broken;
    public AudioClip Explode;
    [Header("Audio Source")]
    public AudioSource ASource;

    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        fixedCover.enabled = true;
        brokenCover.enabled = false;
        ASource.Stop();
        doorAnimator.SetBool("isBroken", false);
    }

    protected override void OnLevelUp(int level)
    {
        switch (level)
        {
            case 0:
                fixedCover.enabled = true;
                brokenCover.enabled = false;
                break;
            case 1:
                ASource.clip = Normal;
                ASource.Play();
                break;
            case 2:
                fixedCover.enabled = false;
                brokenCover.enabled = true;
                ASource.clip = Broken;
                ASource.Play();
                doorAnimator.SetBool("isBroken", true);
                break;
            case 3:
                ASource.Stop();
                ASource.PlayOneShot(Explode, 1.0f);
                Debug.Log("BOOOM!");
                break;
        }
    }
}
