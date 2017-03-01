using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

    public float m_thrust;
    public Rigidbody m_rb;

    // Use this for initialization
    void Start () {
        m_rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {   
        m_rb.AddForce(0, 0, m_thrust, ForceMode.Impulse);        
    }
}
