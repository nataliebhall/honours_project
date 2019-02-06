using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controller : MonoBehaviour
{
    public GameObject first_object;
    GameObject current_object;

    // Use this for initialization
    void Start ()
    {
        current_object = first_object;
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void ChangeObject(GameObject obj)
    {
        current_object = obj;
    }
}
