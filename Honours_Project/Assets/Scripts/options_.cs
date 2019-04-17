using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options_ : MonoBehaviour
{
    public GameObject next_object;

    game_controller game_;
    end_check_ end_;

    public bool is_decision = false;
    public bool is_pos = false;

    // Use this for initialization
    void Start ()
    {
        game_ = GameObject.Find("game_controller").GetComponent<game_controller>();
        end_ = GameObject.Find("end_check").GetComponent<end_check_>();
    }

    public void ButtonClick()
    {
        if (next_object != null)
        {
            if (is_decision)
            {
                end_.Decision(next_object, is_pos);
            }
            else
            {
                game_.ChangeObject(next_object);
            }
        }
        else
        {
            game_.EndGame();
        }
    }
}
