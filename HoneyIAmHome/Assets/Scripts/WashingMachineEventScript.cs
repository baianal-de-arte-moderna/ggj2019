using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingMachineEventScript : ObjectEventScript
{
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
        ASource.Stop();
        doorAnimator.SetBool("isBroken", false);
    }

    protected override void OnLevelUp(int level)
    {
        switch (level)
        {
            case 1:
                ASource.clip = Normal;
                ASource.Play();
                doorAnimator.SetBool("isBroken", false);
                break;
            case 2:
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
