using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveEventScript : ObjectEventScript
{
    public AudioSource ASource;

    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        Debug.Log("Stove under control!");
        ASource.Stop();
    }

    protected override void OnLevelUp(int level)
    {
        Debug.Log("Level Up!");
        ASource.Play();
    }
}
