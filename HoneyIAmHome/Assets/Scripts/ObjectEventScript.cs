using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectEventScript : MonoBehaviour
{
    private int timer;
    public int level;
    public int maxLevel;
    private System.Random rdn = new System.Random();
    
    // Start is called before the first frame update
    void Start()
    {
        timer = rdn.Next(50,500);
        level = 0;
        Debug.Log(timer);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer-1;
        //Debug.Log(timer);
        if(timer == 0){
            timer = rdn.Next(50,500);
            level++;
            OnLevelUp(level);
        }
        if(level == maxLevel){
            OnGameOver();
        }
    }

    public void SolveIssue()
    {
        timer = rdn.Next(50, 500);
        level = 0;
        OnIssueSolved();
    }

    abstract protected void OnGameOver();

    abstract protected void OnIssueSolved();
    
    abstract protected void OnLevelUp(int level);
}
