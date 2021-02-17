using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    Vector2 moveInput;

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;

    void Awake() {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate() {
        Vector2 pos = body2D.position + moveInput * moveSpeed;
        body2D.MovePosition(pos); 
    }
}
