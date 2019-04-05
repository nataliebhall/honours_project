using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game_controller : MonoBehaviour
{
    public GameObject first_object;
    public GameObject current_object;
    public Text canvas_text;

    // Use this for initialization
    void Start ()
    {
        current_object = first_object;
        current_object.GetComponent<event_>().InstantiateButtons();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (current_object)
        {
            canvas_text.text = current_object.GetComponent<event_>().text_;
        }
    }

    public void ChangeObject(GameObject obj)
    {
        current_object.GetComponent<event_>().DestroyButtons();
        current_object = obj;
        current_object.GetComponent<event_>().InstantiateButtons();
    }
    
    public void EndGame()
    {
        current_object.GetComponent<event_>().DestroyButtons();
        current_object = null;
        Application.Quit();
    }
}
