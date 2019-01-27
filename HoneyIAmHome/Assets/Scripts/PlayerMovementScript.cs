using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private Animator animator;
    private Transform m_transform;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_transform = GetComponent<Transform>();
        animator = GetComponentInChildren<Animator>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveVertical != 0f || moveHorizontal != 0f)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.velocity = (movement.normalized * speed);
            m_transform.rotation = Quaternion.LookRotation(rb.velocity);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}
