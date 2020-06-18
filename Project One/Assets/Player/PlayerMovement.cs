using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float dashSpeed;
   
    //private int orientation = 1;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
        
    }

    
    private void FixedUpdate()
    {
       
       //Horizontal Movement
       if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            Dash(1);
        }
       else
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(+speed, rb.velocity.y);

                if (Input.GetKeyDown(KeyCode.LeftShift))
                    Dash(2);
            }
            else
           {
                rb.velocity = new Vector2(0f, rb.velocity.y);
            }
        }

        //Dash
        
    }

    private void Dash(int orientation)
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
           
           

                if(orientation == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                else if (orientation == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }

            }
        }


        
 }

