using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_check_ : MonoBehaviour
{
    // Game objects for each "ending"
    public GameObject end_1;
    public GameObject end_2;
    public GameObject end_3;
    public GameObject end_4;

    // Game controller script to be accessed by this scritpt
    game_controller game_;

    // Integer variables to store the amount of positive options the player has chosen
    public int studio_pos = 0; //max 2
    public int home_pos = 0;   //max 1

    void Start()
    {
        // Finds the game controller script attached to the object in the hierarchy
        game_ = GameObject.Find("game_controller").GetComponent<game_controller>();
    }
    
    // Decision called by the options script if the current event is an option
    public void Decision(GameObject next_object, bool is_pos)
    {
        // Checks the tag of the current object
        if (game_.current_object.tag == "studio")
        {
            // Adds one to the studio variable if the current object is tagged "studio" and the option selected was positive
            if (is_pos)
            {
                studio_pos++;
            }
        }
        else if (game_.current_object.tag == "home")
        {
            // Adds one to the home variable if the current object is tagged "home" and the option selected was positive
            if (is_pos)
            {
                home_pos++;
            }
            // If not positive then it checks if studio variable + home variable are equal to 0
            if (studio_pos == 0)
            {
                if (home_pos == 0)
                {
                    // If they are not then no positive options have been selected and the first ending is triggered
                    next_object = end_1;
                }
            }
        }
        else if (game_.current_object.tag == "conference")
        {
            // The end of the game - checks what decisions the player has made up to this point and sets the next event to the correct ending 
            if (studio_pos == 0)
            {
                if (home_pos == 1)
                {
                    next_object = end_2;
                }
            }
            if (studio_pos == 1)
            {
                if (home_pos == 0)
                {
                    next_object = end_2;
                }
                else
                {
                    next_object = end_3;
                }
            }
            else if (studio_pos == 2)
            {
                if (home_pos == 0)
                {
                    next_object = end_3;
                }
                else
                {
                    next_object = end_4;
                }
            }
        }

        // Change to the next event
        game_.ChangeObject(next_object);
    }
}
