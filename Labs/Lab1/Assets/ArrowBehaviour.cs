using UnityEngine;
using System.Collections;

public class ArrowBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        if (!transform.parent.GetComponent<ClickBallBehaviour>().m_mouseHeld)
        {
            transform.RotateAround(transform.parent.position, new Vector3(0f, 1f, 0f), 150 * Time.deltaTime);
        }
        else if (transform.parent.GetComponent<ClickBallBehaviour>().m_thrust < transform.parent.GetComponent<ClickBallBehaviour>().m_thrustCap)
        {
            print(transform.parent.GetComponent<ClickBallBehaviour>().m_thrust + " " + transform.parent.GetComponent<ClickBallBehaviour>().m_thrustCap);
            transform.localScale += new Vector3(0, Time.deltaTime * 1.5f, 0);
            transform.localPosition += Time.deltaTime * 1.5f * transform.up;
        }
	}
}
