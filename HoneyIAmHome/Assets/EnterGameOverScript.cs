using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterGameOverScript : MonoBehaviour
{
    private Image myImage;
    // Update is called once per frame
    void Start()
    {
        myImage = GetComponent<Image>();
    }
    void Update()
    {
        myImage.color = Color.Lerp(myImage.color, Color.black, 0.05f);
        if (myImage.color.a > 0.99f) {
            SceneManager.LoadScene("GameOver");
        }
    }
}
