using UnityEngine;

public class MicrowaveEventScript : ObjectEventScript
{
    public Animator fireAnimator;
    public AudioClip MicrowaveStart;
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
        ASource.PlayOneShot(MicrowaveStart, 1.0f);
        ASource.Play();
    }
}
