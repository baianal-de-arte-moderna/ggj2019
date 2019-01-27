using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveEventScript : ObjectEventScript
{
    public Animator fireAnimator;
    public AudioSource ASource;

    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        fireAnimator.SetInteger("level", 0);
        ASource.Stop();
    }

    protected override void OnLevelUp(int level)
    {
        fireAnimator.SetInteger("level", level);
        ASource.Play();
    }
}
