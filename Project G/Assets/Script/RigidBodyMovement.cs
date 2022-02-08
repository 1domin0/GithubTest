using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Transform groundCheck;
    private LayerMask groundLayerMask;
    [Space]
    [SerializeField] private float jumpForce = 200;
    [SerializeField] private float moveSpeed = 10;
    [SerializeField] private float maxVelocity = 5;

    private float verticalSpeed;
    private float horizontalSpeed;
    public float playerVelocity;
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        groundCheck = GameObject.Find("GroundCheck").GetComponent<Transform>();
        groundLayerMask = LayerMask.GetMask("Ground");
    }

    private void Update()
    {
        playerVelocity = rb.velocity.magnitude;
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKey("w")) verticalSpeed = 1;
        else if (Input.GetKey("s")) verticalSpeed = -1;
        else verticalSpeed = 0;

        if (Input.GetKey("a")) horizontalSpeed = -1;
        else if (Input.GetKey("d")) horizontalSpeed = 1;
        else horizontalSpeed = 0;

        Vector3 moveVector = transform.TransformDirection(Vector3.ClampMagnitude(new Vector3(horizontalSpeed * moveSpeed, 0f, verticalSpeed * moveSpeed), maxVelocity));
        rb.velocity = new Vector3(moveVector.x, rb.velocity.y, moveVector.z);
    }

    private void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            if (Physics.CheckSphere(groundCheck.position, 0.1f, groundLayerMask))
            {
                rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            }
        }
    }
}