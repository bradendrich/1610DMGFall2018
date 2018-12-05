using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroller : MonoBehaviour
{
    private CharacterController controller;

    public float Gravity = 9.81f;
    public float MoveSpeed = 3.0f;
    public float JumpSpeed = 3.00f;
    private Vector3 position;
    private Vector3 rotation;
    private bool flipped;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position = transform.TransformDirection(position);
        position.x = MoveSpeed * Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.A) && flipped == false)
        {
            transform.Rotate(0, -180, 0);
            flipped = true;
        }

        if (Input.GetKey(KeyCode.D) && flipped == true)
        {
            transform.Rotate(0, 180, 0);
            flipped = false;
        }

        if (controller.isGrounded)
        {
            if (Input.GetButton("Jump"))
            {
                position.y = JumpSpeed;
            }
        }

        position.y -= Gravity * Time.deltaTime;
        controller.Move(position * Time.deltaTime);
    }
}
