using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManagerScript : MonoBehaviour
{
    public List<GameObject> appliances;

    private int level;
    private float timer;

    private List<ObjectEventScript> applianceEventScripts;
    private List<ObjectEventScript> activeApplianceEventScripts;
    private System.Random random;

    private void Start()
    {
        level = 0;
        timer = 0;
        applianceEventScripts = appliances.ConvertAll(appliance => appliance.GetComponentInChildren<ObjectEventScript>());
        activeApplianceEventScripts = new List<ObjectEventScript>();
        random = new System.Random();
    }

    private void Update()
    {
        if (activeApplianceEventScripts.Count > 0)
        {
            activeApplianceEventScripts = activeApplianceEventScripts.FindAll(activeApplianceEventScript => activeApplianceEventScript.IsActive());
            if (activeApplianceEventScripts.Count == 0)
            {
                if (level < appliances.Count)
                {
                    level++;
                }
                timer = random.Next(5, 25);
            }
        }
        else
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                ActivateAppliances();
            }
        }
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
            activeApplianceEventScripts.Add(selectedApplianceEventScript);
        }
    }
}
