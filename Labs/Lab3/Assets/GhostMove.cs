using UnityEngine;
using System.Collections;

public class GhostMove : MonoBehaviour
{

    public float spacing = 1.0f;
    Animator animator;

    public Rigidbody m_rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        m_rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            animator.SetBool("onGround", true);
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            animator.SetBool("onGround", false);
        }        
    }

    void Update()
    {

        Vector3 pos = Vector3.zero;
        animator.SetBool("wasdPressed", false);
        animator.ResetTrigger("spacePressed");

        if (Input.GetKey(KeyCode.W))
        {
            pos.z += spacing;
            animator.SetBool("wasdPressed", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.z -= spacing;
            animator.SetBool("wasdPressed", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= spacing;
            animator.SetBool("wasdPressed", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += spacing;
            animator.SetBool("wasdPressed", true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && animator.GetBool("onGround"))
        {
            m_rb.AddForce(transform.up * 5f, ForceMode.Impulse);
            animator.SetTrigger("spacePressed");
        }

        transform.Translate(pos * Time.deltaTime);
    }
}
