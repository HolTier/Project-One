using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rp;
    private Vector2 moveVelocity;
    private bool canJump = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }

    void Start()
    {
        rp = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), 0);
       // moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            rp.MovePosition(rp.position + new Vector2(1*speed, -1) * Time.fixedDeltaTime);
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            rp.MovePosition(rp.position + new Vector2(-1*speed, -1) * Time.fixedDeltaTime);
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) && canJump == true)
        {
            
            rp.MovePosition(rp.position + new Vector2(0, 10));
            canJump = false;
        }
    }
}
