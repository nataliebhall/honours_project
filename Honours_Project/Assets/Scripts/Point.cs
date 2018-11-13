using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
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
        if (col.gameObject.tag == "dragable")
        {
            col.gameObject.transform.SetParent(this.gameObject.transform);
        }
        Debug.Log("andrew is smelly");
    }


}
