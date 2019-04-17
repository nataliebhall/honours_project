using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game_controller : MonoBehaviour
{
    public GameObject first_object;
    public GameObject current_object;
    public GameObject canvas_text;
    public GameObject thought_text;

    GameObject canvas_text_;
    GameObject thought_text_;

    // Use this for initialization
    void Start ()
    {
        canvas_text_ = Instantiate(canvas_text, new Vector3(-8.0f, 2.0f, 0.0f), Quaternion.identity, GameObject.FindWithTag("canvas").transform);
        thought_text_ = Instantiate(thought_text, new Vector3(-8.0f, 0.0f, 0.0f), Quaternion.identity, GameObject.FindWithTag("canvas").transform);

        current_object = first_object;
        SetUpNewEvent();
    }
	
	// Update is called once per frame
	void Update ()
    {
    }

    void SetUpNewEvent()
    {
        current_object.GetComponent<event_>().InstantiateButtons();
        canvas_text_.GetComponent<Text>().text = current_object.GetComponent<event_>().text_;
        thought_text_.GetComponent<Text>().text = current_object.GetComponent<event_>().thought_;
    }

    public void ChangeObject(GameObject obj)
    {
        current_object.GetComponent<event_>().DestroyButtons();
        current_object = obj;
        SetUpNewEvent();
    }
    
    public void EndGame()
    {
        current_object.GetComponent<event_>().DestroyButtons();
        current_object = null;
        Application.Quit();
    }
}
