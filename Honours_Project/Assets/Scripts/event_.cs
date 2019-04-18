using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class event_ : MonoBehaviour
{
    [System.Serializable]
    public struct op
    {
        [TextArea]
        public string option_text_;

        public GameObject next_object_;

        public bool is_pos_;
    }

    // Text for description of the event
    [TextArea]
    public string text_;

    [TextArea]
    public string thought_;

    // Bool to determine if the options are important decisions
    public bool is_decision = false;

    // Array of options
    public op[] option;
    
    // Array of positions for buttons of options
    Vector3[] positions_ = new Vector3[2];

    // Button prefabs
    public GameObject top_button;
    public GameObject bottom_button;

    // Array of instantiated buttons
    GameObject[] buttons = new GameObject[2];

    public void InstantiateButtons()
    {
        positions_[0] = new Vector3(-8.0f, -2.0f, 0.0f);
        positions_[1] = new Vector3(-8.0f, -3.0f, 0.0f);

        GameObject temp_button;
        temp_button = Instantiate(top_button, GameObject.FindWithTag("canvas").transform);
        temp_button.GetComponentInChildren<Text>().text = option[0].option_text_;
        temp_button.GetComponent<options_>().next_object = option[0].next_object_;
        if (is_decision == true)
        {
            temp_button.GetComponent<options_>().is_decision = true;
            temp_button.GetComponent<options_>().is_pos = option[0].is_pos_;
        }
            
        buttons[0] = temp_button;

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

    public void DestroyButtons()
    {
        foreach (GameObject g_o_ in buttons)
        {
            Destroy(g_o_);
        }
    }
}
