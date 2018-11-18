using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    // Public variables
    public float speed_;
    public bool snapped_ = false;
    public Vector3 to_snap;

    // Private variables
    private bool dragging_ = false;
    private Vector3 target_;
    private bool mouse_up_ = true;
    private Vector3 origin_position;
    private GameController controller;

	// Use this for initialization
	void Start ()
    {
        origin_position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        controller = GameObject.Find("Game_Controller").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (controller.get_is_testing() == false)
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

            if (snapped_ == false && dragging_ == false && mouse_up_ == true)
            {
                transform.position = origin_position;
            }
        }
    }

    private void OnMouseDrag()
    {
        if (controller.get_is_testing() == false)
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
}


