using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {


    bool m_isTouchingPlayer;

    public float m_chaseSpeed;
	// Use this for initialization
	void Start ()
    {
        m_isTouchingPlayer = false;
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            m_isTouchingPlayer = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            m_isTouchingPlayer = false;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (!m_isTouchingPlayer)
        {
            GameObject player = GameObject.Find("player");
            Vector3 playerPos = player.transform.position;
            GetComponent<Rigidbody>().AddForce(Vector3.Normalize(playerPos - transform.position) * m_chaseSpeed, ForceMode.Impulse);
        }
	}
}
