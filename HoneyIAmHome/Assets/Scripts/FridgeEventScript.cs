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
        doorAnimator.SetBool("isBroken", false);
    }

    protected override void OnLevelUp(int level)
    {
        switch (level)
        {
            case 0:
                break;
            case 1:
                doorAnimator.SetBool("isBroken", true);
                break;
            case 2:
                Debug.Log("ICE AGE!");
                break;
        }
    }
}
