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
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {

        Move.x = Input.GetAxisRaw("Horizontal");
        Move.y = Input.GetAxisRaw("Vertical");

        controller.Move(Move.normalized * moveSpeed * Time.deltaTime);
    }
}
