using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class event_ : MonoBehaviour
{
    [TextArea]
    public string text_;

    public int option_num_;

    public string[] option_text_;

    public GameObject[] next_object_;

    Vector3[] positions_ = new Vector3[2];

    public GameObject button;

    // Use this for initialization
    void Start ()
    {
        positions_[0] = new Vector3(-6.0f, -2.0f, 0.0f);
        positions_[1] = new Vector3(-7.0f, -3.0f, 0.0f);

        for (int i = 0; i < option_num_; i++)
        {
            Instantiate(button, positions_[i], Quaternion.identity, GameObject.FindWithTag("canvas").transform);
            button.GetComponentInChildren<Text>().text = option_text_[i];
            button.GetComponent<options_>().next_object = next_object_[i];
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
