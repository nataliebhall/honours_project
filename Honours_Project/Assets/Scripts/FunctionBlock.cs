using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FunctionBlock : MonoBehaviour
{
    // Function attached to block
    public enum function_types { MOVE_LEFT, MOVE_RIGHT, ATTACK, DUCK, JUMP };
    public function_types function;

    // Use this for initialization
    void Start ()
    {
        this.GetComponentInChildren<Text>().text = function.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
