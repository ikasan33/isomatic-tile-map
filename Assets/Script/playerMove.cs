using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    private playerAnimation playerAnimation;
    public float movespeed = 1.0f;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation=FindObjectOfType<playerAnimation>();
        
    }

    private void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 currenPos = rb.position;
        Vector2 inputVector = new Vector2(moveH, moveV).normalized * movespeed * Time.fixedDeltaTime;
        
        rb.MovePosition(currenPos + inputVector);
        
        playerAnimation.SetDirection(new Vector2(moveH,moveV));
    }
}
