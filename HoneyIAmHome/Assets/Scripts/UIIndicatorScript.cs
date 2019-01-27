using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIIndicatorScript : MonoBehaviour
{
    public Image indicator;
    Vector3 MinPos;
    Vector3 MaxPos;

    ObjectEventScript EventScript;
    // Start is called before the first frame update
    void Start()
    {
        MinPos = Vector3.one * indicator.GetComponent<RectTransform>().sizeDelta.x;
        MaxPos = new Vector3(Screen.width - indicator.GetComponent<RectTransform>().sizeDelta.x, Screen.height - indicator.GetComponent<RectTransform>().sizeDelta.y, 0.0f);
        EventScript = GetComponentInChildren<ObjectEventScript>();
    }

    // Update is called once per frame
    void Update()
    {
        indicator.transform.position = 
            Vector3.Max(
                Vector3.Min(
                    Camera.main.WorldToScreenPoint(transform.position),
                    MaxPos
                ),
                MinPos
            );
            indicator.enabled = (EventScript.level > 0);
            indicator.color = (EventScript.level >= EventScript.maxLevel)? Color.red: Color.yellow;
    }
}
