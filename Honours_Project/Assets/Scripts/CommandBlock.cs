using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CommandBlock : MonoBehaviour
{
    // Command attached to block
    public enum command_types { LEFT, RIGHT, UP, DOWN, SPACE };
    public command_types command;

    // Use this for initialization
    void Start ()
    {
        this.GetComponentInChildren<Text>().text = command.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
