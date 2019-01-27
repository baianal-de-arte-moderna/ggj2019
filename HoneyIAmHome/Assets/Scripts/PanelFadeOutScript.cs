using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelFadeOutScript : MonoBehaviour
{
    private Image myImage;
    // Start is called before the first frame update
    void Start()
    {
        myImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        myImage.color = Color.Lerp(myImage.color, Color.clear, 0.05f);
    }
}
