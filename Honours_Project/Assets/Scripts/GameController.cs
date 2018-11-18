using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool is_testing = false;
    GameObject testing_screen_;

	// Use this for initialization
	void Start ()
    {
        testing_screen_ = GameObject.Find("testing_mode");
        testing_screen_.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (is_testing)
        {
            testing_screen_.SetActive(true);
        }
        else
        {
            testing_screen_.SetActive(false);
        }
	}
    public void Quit_Game()
    {
        Application.Quit();
    }

    public void Test_Game()
    {
        is_testing = !is_testing;
    }

    public bool get_is_testing()
    {
        return is_testing;
    }
}
