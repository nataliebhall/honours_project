using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotBehaviour: MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    private void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.gameObject.tag == this.gameObject.tag)
        {
            col.gameObject.GetComponent<BallBehaviour>().snapped_ = true;
            col.gameObject.GetComponent<BallBehaviour>().to_snap = this.gameObject.transform.position;

        }
    }
}
