using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkEventScript : ObjectEventScript
{
    public Animator waterAnimator;

    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        waterAnimator.SetInteger("level", 0);
    }

    protected override void OnLevelUp(int level)
    {
        waterAnimator.SetInteger("level", level);
    }
}
