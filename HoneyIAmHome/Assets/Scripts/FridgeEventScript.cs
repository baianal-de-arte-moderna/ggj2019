using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeEventScript : ObjectEventScript
{
    public Animator doorAnimator;
    public AudioClip FridgeLoop;
    public AudioClip IceAge;
    public AudioSource ASource;

    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        doorAnimator.SetInteger("level", 0);
        ASource.Stop();
    }

    protected override void OnLevelUp(int level)
    {
        switch (level)
        {
            case 1:
                doorAnimator.SetInteger("level", level);
                ASource.Stop();
                ASource.clip = FridgeLoop;
                ASource.Play();
                break;
            case 2:
                doorAnimator.SetInteger("level", level);
                ASource.Stop();
                ASource.clip = IceAge;
                ASource.Play();
                break;
            case 3:
                Debug.Log("ICE AGE!");
                ASource.Stop();
                break;
        }
    }
}
