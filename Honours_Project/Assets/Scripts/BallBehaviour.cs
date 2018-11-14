using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    // Variables
    public float speed_;
    public bool snapped_ = false;
    public Vector3 to_snap;
    bool dragging_ = false;
    private Vector3 target_;
    bool mouse_up_ = true;

    // Command attached to block
    public enum command_types {LEFT, RIGHT, UP, DOWN, SPACE};
    public command_types command;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (snapped_ == true && dragging_ == false && mouse_up_ == true)
        {
            transform.position = new Vector3(to_snap.x, to_snap.y, transform.position.z);
        }

        if (dragging_ == true && mouse_up_ == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target_, speed_ * Time.deltaTime);
        }

        if (Input.GetMouseButtonUp(0))
        {
            mouse_up_ = true;
            dragging_ = false;
        }
    }

    private void OnMouseDrag()
    {
        target_ = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target_.z = transform.position.z;
        if (dragging_ == false && mouse_up_ == true)
        {
            dragging_ = true;
            snapped_ = false;
            mouse_up_ = false;
        }
    } 

    
}


