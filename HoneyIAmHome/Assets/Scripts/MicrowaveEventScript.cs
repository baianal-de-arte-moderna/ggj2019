using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrowaveEventScript : ObjectEventScript
{
    public AudioClip MicrowaveStart;
    public AudioSource ASource;
    protected override void OnGameOver()
    {
        Debug.Log("Game Over :c");
    }

    protected override void OnIssueSolved()
    {
        Debug.Log("The microwave didn't explode!");
        ASource.Stop();
    }

    protected override void OnLevelUp(int level)
    {
        Debug.Log("level up!");
        ASource.PlayOneShot(MicrowaveStart, 1.0f);
        ASource.Play();
    }
}
