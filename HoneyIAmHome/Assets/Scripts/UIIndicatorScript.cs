using UnityEngine;
using UnityEngine.UI;

public class UIIndicatorScript : MonoBehaviour
{
    public Image indicator;
    private Image internalIndicator;
    Vector3 MinPos;
    Vector3 MaxPos;
    ObjectEventScript EventScript;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        internalIndicator = indicator.GetComponent<RectTransform>().GetChild(0).GetComponent<Image>();
        MinPos = Vector3.one * indicator.GetComponent<RectTransform>().sizeDelta.x;
        MaxPos = new Vector3(Screen.width - indicator.GetComponent<RectTransform>().sizeDelta.x, Screen.height - indicator.GetComponent<RectTransform>().sizeDelta.y, 0.0f);
        EventScript = GetComponentInChildren<ObjectEventScript>();
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        indicator.transform.position =
            Vector3.Max(
                Vector3.Min(
                    Camera.main.WorldToScreenPoint(transform.position),
                    MaxPos
                ),
                MinPos
            );
        if (EventScript.level >= EventScript.maxLevel)
        {
            indicator.enabled = true;
            indicator.color = Color.red;
        }
        else if (EventScript.level > 0)
        {
            indicator.enabled = true;
            indicator.color = ((count / ((EventScript.maxLevel - EventScript.level) * 6)) % 2 == 0) ? Color.clear : Color.white;
            count++;
        }
        else
        {
            indicator.enabled = false;
            count = 0;
        }
        internalIndicator.enabled = indicator.enabled;
        internalIndicator.color = indicator.color;
    }
}
