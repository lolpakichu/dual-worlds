using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rb;
    public float MovementSpeed = 7f;
    public float jumpForce;
    private float movementInput;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask WhatIsGround;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, WhatIsGround);

        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * jumpForce;
        }

	}

    void FixedUpdate()
    {
        movementInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(movementInput * MovementSpeed, rb.velocity.y);
    }
}
