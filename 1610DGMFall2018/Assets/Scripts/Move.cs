﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 MoveSpeed;
    public Vector3 RotateSpeed;
    public float speed;
    public GameObject Collectable;
    public CharacterController Character;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        RotateSpeed.y = speed * Time.deltaTime;
        Collectable.transform.Rotate(RotateSpeed);
        /*
        MoveSpeed.z = speed * Input.GetAxis("Vertical");
        MoveSpeed.x = speed * Input.GetAxis("Horizontal");
        MoveSpeed *= Time.deltaTime;

        Character.Move(MoveSpeed); */
	}
}
