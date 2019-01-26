using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrowaveEventScript : ObjectEventScript
{
    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        Debug.Log("The microwave didn't explode!");
    }

    protected override void OnLevelUp(int level){
        Debug.Log("level up!");
    }
}
