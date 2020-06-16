using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private LayerMask platformLeyerMask;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider2D;
    public float speed = 10f;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * speed;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D =  Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, .1f, platformLeyerMask);
        Debug.Log(raycastHit2D.collider);
        return raycastHit2D.collider != null;
    }
}
