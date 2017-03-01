using UnityEngine;
using System.Collections;

public class TimeBallBehaviour : MonoBehaviour {

    public float m_thrustCap;
    public Rigidbody m_rb;
    public float m_timer;

    // Use this for initialization
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_timer -= Time.deltaTime;
        if (m_timer <= 0)
        {
           ;
            float xComponent = Random.Range(m_thrustCap / 2, m_thrustCap) * (Random.Range(0, 2) == 0 ? -1 : 1);
            float zComponent = Random.Range(m_thrustCap / 2, m_thrustCap) * (Random.Range(0, 2) == 0 ? -1 : 1);
            m_rb.AddForce(xComponent, 0, zComponent, ForceMode.Impulse);
            m_timer = 1.5f;
        }
    }
}
