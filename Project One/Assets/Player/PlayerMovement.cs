using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
       moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
       if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(+speed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(0f, rb.velocity.y);
            }
        }
    }
}
