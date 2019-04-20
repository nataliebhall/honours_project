using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_ : MonoBehaviour 
{
    // Game objects to be set active/inactive
    GameObject start;
    GameObject play;

    private void Start()
    {
        // Initialise game objects by finding them in the hierarchy
        start = GameObject.Find("start");
        play = GameObject.Find("play");

        // Set play as inactive to begin with
        play.SetActive(false);
    }

    // Called when start button is selected by player
    public void StartButton()
    {
        // Set start as inactive and play as active
        start.SetActive(false);
        play.SetActive(true);
    }

    // Called when play button is selected by the player
    public void PlayButton()
    {
        // Load the main game scene in
        SceneManager.LoadScene(1);
    }
}
