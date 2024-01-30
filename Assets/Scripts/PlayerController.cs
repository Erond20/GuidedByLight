using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;

    public float moveSpeed = 10f;
    Vector2 Move;


    private void Start()
    {
        //Reference for Character Controller
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        //Input For Movement
        Move.x = Input.GetAxisRaw("Horizontal");
        Move.y = Input.GetAxisRaw("Vertical");
        //Normalized Movement So It Couldnt Go Faster Diagonally 
        controller.Move(Move.normalized * moveSpeed * Time.deltaTime);
    }
}
