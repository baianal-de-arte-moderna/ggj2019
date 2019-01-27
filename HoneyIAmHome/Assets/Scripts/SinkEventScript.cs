using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkEventScript : ObjectEventScript
{
    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        Debug.Log("The sink is no longer leaking!");
    }

    protected override void OnLevelUp(int level)
    {
        Debug.Log("level up!");
    }
}
