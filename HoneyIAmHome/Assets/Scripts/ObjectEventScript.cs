using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectEventScript : MonoBehaviour
{
    public int level;
    public int maxLevel;

    private float timer;
    private float levelDuration;

    // Start is called before the first frame update
    void Start()
    {
        level = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer = levelDuration;
                OnLevelUp(++level);
            }

            if (level == maxLevel)
            {
                OnGameOver();
            }
        }
    }

    public void SetLevelDuration(float newLevelDuration)
    {
        Debug.Log($"Activating {GetType().Name} with level duration {newLevelDuration}");
        levelDuration = newLevelDuration;
        timer = levelDuration;
    }

    public void SolveIssue()
    {
        level = 0;
        timer = 0;
        OnIssueSolved();
    }

    abstract protected void OnGameOver();

    abstract protected void OnIssueSolved();

    abstract protected void OnLevelUp(int level);
}
