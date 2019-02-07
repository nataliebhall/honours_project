using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options_ : MonoBehaviour
{
    public GameObject next_object;

    game_controller game_;
    
	// Use this for initialization
	void Start ()
    {
        game_ = GameObject.Find("game_controller").GetComponent<game_controller>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ButtonClick()
    {
        if (next_object != null)
        {
            game_.ChangeObject(next_object);
            
        }
        else
        {
            game_.EndGame();
        }
    }
}
