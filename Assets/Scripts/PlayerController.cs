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
    public GameObject enemy;

    private SpriteRenderer gunSprite;
    public GameObject gun;
    public EnemyFollow enemyFollow;

    // Use this for initialization
    void Start () {
        enemyFollow = enemy.GetComponent<EnemyFollow>();
        gunSprite = gun.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
    
        if(enemyFollow.isLevelComplete){
            MovementSpeed = 0f;
        } else {
            MovementSpeed = 7f; 
        }

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, WhatIsGround);

        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * jumpForce;
        }

	}

    void FixedUpdate()
    {
        movementInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movementInput * MovementSpeed, rb.velocity.y);

        if(movementInput > 0){
            transform.eulerAngles = new Vector3(0, 0, 0);
            gunSprite.flipX = false;
        } else if(movementInput < 0){
            transform.eulerAngles = new Vector3(0, 180, 0);
            gunSprite.flipX = true;
        }
        
    }
   
}
