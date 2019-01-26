using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;

    Transform m_transform;

    // Start is called before the first frame update
    void Start()
    {
        m_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        m_transform.position = Vector3.Lerp(m_transform.position, Player.position + Offset, 0.2f);
        m_transform.LookAt(Player);
    }
}
