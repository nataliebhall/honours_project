using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_ : MonoBehaviour 
{
    GameObject start;
    GameObject play;

    private void Start()
    {
        start = GameObject.Find("start");
        play = GameObject.Find("play");

        play.SetActive(false);
    }

    public void StartButton()
    {
        start.SetActive(false);
        play.SetActive(true);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
