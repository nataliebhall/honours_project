using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game_controller : MonoBehaviour
{
    // First gameobject - to be dragged into the inspector
    public GameObject first_object;

    // The current event - public so it can be accessed by other scripts
    public GameObject current_object;

    // Prefab of canvas text to be instantiated
    public GameObject canvas_text_;

    // Canvas text variable
    GameObject canvas_text;

    // Use this for initialization
    void Start ()
    {
        // Instantiate the canvas text
        canvas_text = Instantiate(canvas_text_, GameObject.FindWithTag("canvas").transform);
        
        // Set the current object as the first object then set up the new event
        current_object = first_object;
        SetUpNewEvent();
    }

    // Called by Start and Change Object
    void SetUpNewEvent()
    {
        // Instantiates the buttons for the event by calling the function on the event script
        current_object.GetComponent<event_>().InstantiateButtons();
        // Get the event description from the current event script and set the canvas text to it
        canvas_text.GetComponent<Text>().text = current_object.GetComponent<event_>().text_;
    }

    // Change object called when the player clicks on a button
    public void ChangeObject(GameObject obj)
    {
        // Destroys the buttons on the "old" event
        current_object.GetComponent<event_>().DestroyButtons();
        // Sets the current event to the new event
        current_object = obj;
        // Set up the new event
        SetUpNewEvent();
    }
    
    // Called when the last event has happened
    public void EndGame()
    {
        // Destroy the current objects buttons and set the current object to null
        current_object.GetComponent<event_>().DestroyButtons();
        current_object = null;
        // Quit the application
        Application.Quit();
    }
}
