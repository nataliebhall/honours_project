using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMode : MonoBehaviour
{
    // Variables
    GameController controller;
    SlotBehaviour command_slot;
    SlotBehaviour function_slot;
    FunctionBlock.function_types function_;
    CommandBlock.command_types command_;


    // Use this for initialization
    void Start ()
    {
        controller = GetComponent<GameController>();
        command_slot = GetComponentInChildren<SlotBehaviour>();
        function_slot = GetComponentInChildren<SlotBehaviour>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (controller.get_is_testing() == true)
        {
            
        }
	}
}
