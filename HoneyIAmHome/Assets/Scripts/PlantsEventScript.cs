using UnityEngine;

public class PlantsEventScript : ObjectEventScript
{
    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        Debug.Log("The plant is alive!");
    }

    protected override void OnLevelUp(int level)
    {
        Debug.Log("level up!");
    }
}
