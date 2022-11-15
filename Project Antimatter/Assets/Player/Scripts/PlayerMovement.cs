using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed;
    public float input;
    public SpriteRenderer spriteRenderer;
    public float jumpForce;

    public LayerMask groundlayer;
    private bool isGrounded;
    public Transform feetPosition;
    public float groundCheckCircle;

    public float jumpTime = 0.35f;
    public float jumpTimeCounter;

    public Animator animator;

    private bool isJumping;

    private Vector3 respawnPoint;
    

    public bool flippedLeft;
    public bool facingRight;

    //Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        if(input < 0)
        {
            facingRight = false;
            Flip(false);
        }
        else if (input > 0)
        {
            facingRight = true;
            Flip(true);
        }

        animator.SetFloat("Speed", Mathf.Abs(input));

        isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundCheckCircle, groundlayer);

        if (isGrounded == true && Input.GetButton("Jump"))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            playerRb.velocity = Vector2.up * jumpForce;
            //animator.SetBool("IsJumping", true);
        }

        if (Input.GetButton("Jump") && isJumping == true)
        {
            if(jumpTimeCounter > 0)
            {
                playerRb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
                animator.SetBool("IsJumping", true);
            }

            else
            {
                isJumping = false; 
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
            animator.SetBool("IsJumping", false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }
    }

    void FixedUpdate()
    {
        playerRb.velocity = new Vector2(input * speed, playerRb.velocity.y);
    }

    void Flip (bool facingRight)
    {
        if(flippedLeft && facingRight)
        {
            transform.Rotate(0, -180, 0);
            flippedLeft = false;
        }
        if(!flippedLeft && !facingRight)
        {
            transform.Rotate(0, -180, 0);
            flippedLeft = true;
        }
    }
}
