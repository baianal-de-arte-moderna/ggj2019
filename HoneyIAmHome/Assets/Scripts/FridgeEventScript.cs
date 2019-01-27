using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeEventScript : ObjectEventScript
{
    public Animator doorAnimator;

    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        doorAnimator.SetInteger("level", 0);
    }

    protected override void OnLevelUp(int level)
    {
        switch (level)
        {
            case 1:
                doorAnimator.SetInteger("level", level);
                break;
            case 2:
                doorAnimator.SetInteger("level", level);
                break;
            case 3:
                Debug.Log("ICE AGE!");
                break;
        }
    }
}
