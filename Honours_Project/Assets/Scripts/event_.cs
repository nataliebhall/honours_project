using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class event_ : MonoBehaviour
{
    [System.Serializable]
    // Struct for each option 
    public struct op
    {
        // Text for inside each button
        [TextArea]
        public string option_text_;

        // The next event for this option
        public GameObject next_object_;

        // If the option is positive (only applicable for decision events)
        public bool is_pos_;
    }

    // Text for description of the event
    [TextArea]
    public string text_;

    // Bool to determine if the options are important decisions
    public bool is_decision = false;

    // Array of options
    public op[] option;

    // Button prefabs
    public GameObject top_button;
    public GameObject bottom_button;

    // Array of instantiated buttons
    GameObject[] buttons = new GameObject[2];

    // Called by the game_controller 
    public void InstantiateButtons()
    {
        // OPTION ONE // 
        // Make a temporary button object
        GameObject temp_button;
        // Instantiate top button game object
        temp_button = Instantiate(top_button, GameObject.FindWithTag("canvas").transform);
        // Set up text of button
        temp_button.GetComponentInChildren<Text>().text = option[0].option_text_;
        // Set up variables on the options_ script attached to the button 
        temp_button.GetComponent<options_>().next_object = option[0].next_object_;
        // Decision and positive variables only set if necessary
        if (is_decision == true)
        {
            temp_button.GetComponent<options_>().is_decision = true;
            temp_button.GetComponent<options_>().is_pos = option[0].is_pos_;
        }
        // New button then stored in an array for when they get deleted
        buttons[0] = temp_button;

        // OPTION TWO //
        // Checks if there is a second option and set it up the same way
        if (option.Length == 2)
        {
            temp_button = Instantiate(bottom_button, GameObject.FindWithTag("canvas").transform);
            temp_button.GetComponentInChildren<Text>().text = option[1].option_text_;
            temp_button.GetComponent<options_>().next_object = option[1].next_object_;
            if (is_decision == true)
            {
                temp_button.GetComponent<options_>().is_decision = true;
                temp_button.GetComponent<options_>().is_pos = option[1].is_pos_;
            }

            buttons[1] = temp_button;
        }
    }

    // Called by game_controller when changing object or ending the game
    public void DestroyButtons()
    {
        // Destroys each game object in the array of buttons
        foreach (GameObject g_o_ in buttons)
        {
            Destroy(g_o_);
        }
    }
}
