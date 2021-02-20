using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 moving = new Vector2();
    public bool flip_x, flip_y;

    void Update()
    {
        moving.x = moving.y = 0;
        float move_x = Input.GetAxis("Horizontal");
        float move_y = Input.GetAxis("Vertical");
        if (move_x != 0) {
            flip_x = move_x > 0;
            moving.x = flip_x ? 1 : -1;
        }
        if (move_y != 0) {
            flip_y = move_y > 0;
            moving.y = flip_y ? 1 : -1;
        }
    }
}
