using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options_ : MonoBehaviour
{
    // Game object of the next event
    public GameObject next_object;
    
    // Scripts to be accessed by this script
    game_controller game_;
    end_check_ end_;

    // Bools to determine whether the current event is a decision
    public bool is_decision = false;
    public bool is_pos = false;

    // Use this for initialization
    void Start ()
    {
        // Initialise scripts by finding the game objects they are attached to in the hierarchy
        game_ = GameObject.Find("game_controller").GetComponent<game_controller>();
        end_ = GameObject.Find("end_check").GetComponent<end_check_>();
    }

    // ButtonClick called when the player clicks on the button
    public void ButtonClick()
    {
        // If the next object is not null the game is not over
        if (next_object != null)
        {
            // If the current event is a decision then call Decision on the end_check script
            if (is_decision)
            {
                end_.Decision(next_object, is_pos);
            }
            else
            {
                // If it is not a decision then change to the next event
                game_.ChangeObject(next_object);
            }
        }
        else
        {
            // The game has finished, call EndGame to end the application
            game_.EndGame();
        }
    }
}
