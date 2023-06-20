using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    private float moveH, moveV;
    public float movespeed = 2.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal") * movespeed;
        moveV = Input.GetAxisRaw("Vertical") * movespeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveH, moveV).normalized;
    }
}
