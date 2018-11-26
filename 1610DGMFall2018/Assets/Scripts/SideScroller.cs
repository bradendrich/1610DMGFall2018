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

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //rotation.Set(0, Input.GetAxis("Horizontal"), 0);
        //transform.Rotate(rotation);
        if (controller.isGrounded)
        {
            position.Set(MoveSpeed * Input.GetAxis("Horizontal"), 0, 0);
            position = transform.TransformDirection(position);

            if (Input.GetButton("Jump"))
            {
                position.y = JumpSpeed;
            }
        }

        position.y -= Gravity * Time.deltaTime;
        controller.Move(position * Time.deltaTime);
    }
}
