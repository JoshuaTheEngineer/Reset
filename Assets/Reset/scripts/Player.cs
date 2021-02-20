using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    Vector2 moveInput;

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;
    private PlayerController controller;

    void Awake() {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
    }
    
    void Update()
    {
        moveInput = new Vector2(controller.moving.x, controller.moving.y);
        renderer2D.flipX = controller.flip_x;
        renderer2D.flipY = controller.flip_y;
        Vector2 pos = body2D.position + moveInput * moveSpeed;
        body2D.MovePosition(pos); 
    }
}
