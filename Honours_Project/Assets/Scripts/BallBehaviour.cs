using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float speed_;
    private bool move_ = false;
    private Vector3 target_;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (move_ == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target_, speed_*Time.deltaTime);
        }
	}

    private void OnMouseDrag()
    {
        target_ = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target_.z = transform.position.z;
        if (move_ == false)
        {
            move_ = true;
        }
    }
}


