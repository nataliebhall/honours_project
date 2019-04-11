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

        public bool not_interactable;
    }

    [TextArea]
    public string text_;

    public op[] option;

    Vector3[] positions_ = new Vector3[2];

    public GameObject button;

    GameObject[] buttons = new GameObject[2];

    // Use this for initialization
    void Start ()
    {
    }

    public void InstantiateButtons()
    {
        positions_[0] = new Vector3(-8.0f, -2.0f, 0.0f);
        positions_[1] = new Vector3(-8.0f, -3.0f, 0.0f);

        for (int i = 0; i < option.Length; i++)
        {
            GameObject temp_button;
            temp_button = Instantiate(button, positions_[i], Quaternion.identity, GameObject.FindWithTag("canvas").transform);
            temp_button.GetComponentInChildren<Text>().text = option[i].option_text_;
            temp_button.GetComponent<options_>().next_object = option[i].next_object_;
            
            if (option[i].not_interactable == true)
            {
                temp_button.GetComponent<Button>().interactable = false;
            }
            
            buttons[i] = temp_button;
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
