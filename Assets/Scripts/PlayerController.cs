using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed = 10f;
    Vector2 Move;


    private void Start()
    {
        //Reference for Rigidbody 2D
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        //Input For Movement
        Move.x = Input.GetAxisRaw("Horizontal");
        Move.y = Input.GetAxisRaw("Vertical");
        //Apply Movement
        Move.Normalize();
    }
    private void FixedUpdate()
    {
        rb.velocity = Move * moveSpeed;
    }
}