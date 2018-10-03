using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;

    public float Gravity = 9.81f;
    public float MoveSpeed = 3.0f;
    public float JumpSpeed = 3.00f;
    private Vector3 position;
    private Vector3 rotation;

	void Start ()
    {
        controller = GetComponent<CharacterController>();	
	}
	
	void Update ()
    {
        rotation.Set(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(rotation);
        if (controller.isGrounded)
        {
            position.Set(0, 0, MoveSpeed * Input.GetAxis("Vertical"));
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
