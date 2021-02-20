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
    private Animator animator;

    void Awake() {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput = new Vector2(controller.moving.x, controller.moving.y);
        Vector2 pos = body2D.position + moveInput * moveSpeed;
        body2D.MovePosition(pos);
        if(controller.moving.x == 0 && controller.moving.y == 0) animator.SetInteger("AnimState", 0);
        if(controller.moving.x != 0) {
            if(controller.flip_x) animator.SetInteger("AnimState", 2);
            else animator.SetInteger("AnimState", 4);
        }
        if(controller.moving.y != 0) {
            if(controller.flip_y) animator.SetInteger("AnimState", 1);
            else animator.SetInteger("AnimState", 3);
        }
    }
}
