using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManagerScript : MonoBehaviour
{
    public List<GameObject> appliances;

    private List<ObjectEventScript> applianceEventScripts;
    private System.Random random;

    private int level;
    private float activeTimer;
    private float idleTimer;

    private void Start()
    {
        applianceEventScripts = appliances.ConvertAll(appliance => appliance.GetComponentInChildren<ObjectEventScript>());
        random = new System.Random();
        level = 0;
        activeTimer = 0;
        idleTimer = 0;

        ActivateIdleMode();
    }

    private void Update()
    {
        if (activeTimer > 0)
        {
            activeTimer -= Time.deltaTime;
            if (activeTimer <= 0)
            {
                if (level < appliances.Count)
                {
                    level++;
                }
                idleTimer = random.Next(5, 25);
            }
        }
        else
        {
            idleTimer -= Time.deltaTime;
            if (idleTimer <= 0)
            {
                ActivateAppliances();
            }
        }
    }

    private void ActivateIdleMode()
    {
        idleTimer = random.Next(5, 25);
        Debug.Log($"Stay in idle mode for {idleTimer} seconds");
    }

    private void ActivateAppliances()
    {
        // Selecting random appliances to be activated
        int numberOfSelectedAppliances = Math.Min(random.Next(level / 2 + 1, level + 1), appliances.Count);

        List<ObjectEventScript> unselectedApplianceEventScripts = new List<ObjectEventScript>(applianceEventScripts);
        List<ObjectEventScript> selectedApplianceEventScripts = new List<ObjectEventScript>();
        while (selectedApplianceEventScripts.Count < numberOfSelectedAppliances)
        {
            int randomIndex = random.Next(0, unselectedApplianceEventScripts.Count);
            selectedApplianceEventScripts.Add(unselectedApplianceEventScripts[randomIndex]);
            unselectedApplianceEventScripts.RemoveAt(randomIndex);
        }

        foreach (ObjectEventScript selectedApplianceEventScript in selectedApplianceEventScripts)
        {
            float randomLevelDuration = random.Next(5, 25);
            selectedApplianceEventScript.SetLevelDuration(randomLevelDuration);

            activeTimer = Math.Max(activeTimer, selectedApplianceEventScript.maxLevel * randomLevelDuration);
        }

        Debug.Log($"Stay in active mode for {activeTimer} seconds");
    }
}
