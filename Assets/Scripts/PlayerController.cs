﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float HorizontalInput;
    public float MovementSpeed;
    public float JumpForce;
    public float GravityModifier;
    public float xRange = 12.0f;
    public bool IsOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= GravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {

        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * HorizontalInput * Time.deltaTime * MovementSpeed);
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround)
        {
            playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            IsOnGround = false;
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsOnGround = true;
    }
}
