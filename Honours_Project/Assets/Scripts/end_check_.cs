using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_check_ : MonoBehaviour
{
    public GameObject end_1;
    public GameObject end_2;
    public GameObject end_3;
    public GameObject end_4;

    game_controller game_;

    int studio_pos = 0; //max 2
    int home_pos = 0;   //max 1

    void Start()
    {
        game_ = GameObject.Find("game_controller").GetComponent<game_controller>();
    }

    public void Decision(GameObject next_object, bool is_pos)
    {
        if (game_.current_object.tag == "studio")
        {
            if (is_pos)
            {
                studio_pos++;
            }
        }
        else if (game_.current_object.tag == "home")
        {
            if (is_pos)
            {
                home_pos++;
            }
            else if (studio_pos + home_pos == 0)
            {
                next_object = end_1;
            }
        }
        else if (game_.current_object.tag == "conference")
        {
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

        game_.ChangeObject(next_object);
    }
}
