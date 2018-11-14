using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotBehaviour: MonoBehaviour
{
    bool slotted = false;
    GameObject current_collider;

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
            if (slotted == false)
            {
                current_collider = col.gameObject;
                col.gameObject.GetComponent<BallBehaviour>().snapped_ = true;
                col.gameObject.GetComponent<BallBehaviour>().to_snap = this.gameObject.transform.position;
                slotted = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject == current_collider)
        {
            col.gameObject.GetComponent<BallBehaviour>().snapped_ = false;
            current_collider = null;
            slotted = false;
        }
    }
}
