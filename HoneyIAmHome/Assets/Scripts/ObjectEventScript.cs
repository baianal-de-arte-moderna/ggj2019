using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectEventScript : MonoBehaviour
{
    private float timer;
    public int level;
    public int maxLevel;
    private System.Random rdn = new System.Random();
    
    // Start is called before the first frame update
    void Start()
    {
        timer = (float) rdn.Next(5,25);
        level = 0;
        Debug.Log(timer);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f){
            timer = (float) rdn.Next(10,25);
            level++;
            OnLevelUp(level);
        }
        if(level == maxLevel){
            OnGameOver();
        }
    }

    public void SolveIssue()
    {
        timer = (float) rdn.Next(10,25);
        level = 0;
        OnIssueSolved();
    }

    abstract protected void OnGameOver();

    abstract protected void OnIssueSolved();
    
    abstract protected void OnLevelUp(int level);
}
