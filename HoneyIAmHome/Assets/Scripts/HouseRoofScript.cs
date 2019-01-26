using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseRoofScript : MonoBehaviour
{
    public Renderer Roof;
    // Start is called before the first frame update
    Color targetColor;
    void Start()
    {
        targetColor = new Color(1f,1f,1f,1f);
        Roof.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Roof.material.color = Color.Lerp(Roof.material.color, targetColor, 0.1f);
        Roof.enabled = (Roof.material.color.a > 0.1f);
    }

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            targetColor = new Color(1f,1f,1f,0f);
        }
    }

    void OnCollisionExit (Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            targetColor = new Color(1f,1f,1f,1f);
        }
    }
}
