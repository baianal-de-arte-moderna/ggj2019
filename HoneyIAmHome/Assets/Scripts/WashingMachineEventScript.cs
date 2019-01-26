using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingMachineEventScript : ObjectEventScript
{
    public MeshRenderer fixedCover;
    public MeshRenderer brokenCover;

    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        fixedCover.enabled = true;
        brokenCover.enabled = false;
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
                fixedCover.enabled = false;
                brokenCover.enabled = true;
                break;
            case 2:
                Debug.Log("BOOOM!");
                break;
        }
    }
}
