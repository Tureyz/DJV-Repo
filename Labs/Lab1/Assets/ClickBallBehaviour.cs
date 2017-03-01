using UnityEngine;
using System.Collections;

public class ClickBallBehaviour : MonoBehaviour {


    public float m_thrust = 0f;
    public float m_thrustCap = 3.5f;
    public bool m_mouseHeld;
    public Rigidbody m_rb;
    // Use this for initialization
    void Start () {
        m_rb = GetComponent<Rigidbody>();
    }
	
    void OnMouseDown()
    {
        m_mouseHeld = true;        
    }

    void OnMouseUp()
    {
        GameObject arrow = GameObject.Find("Arrow");

        m_rb.AddForce((transform.position - arrow.transform.position) * -m_thrust, ForceMode.Impulse);
        m_mouseHeld = false;
        arrow.SetActive(false);
    }

	// Update is called once per frame
	void Update ()
    {	
        if (m_mouseHeld)
        {
            m_thrust = Mathf.Clamp(m_thrust + (Time.deltaTime * 1.5f), 0, m_thrustCap);            
        }
	}
}
