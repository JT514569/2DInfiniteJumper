using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D body;
    private BoxCollider2D col;
    private Animator anim;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    private float horizontalInput;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        col = GetComponent<BoxCollider2D>();
        float _time;

    }

    private void FixedUpdate()
    {
        KnowInput();
    }

    public void KnowInput()
    {
        //Calculate if the player is pushing left or right
        horizontalInput = Input.GetAxis("Horizontal");

        //Player left and right flipping
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(0.5f, 0.9f, 1);

        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-0.5f, 0.9f, 1);

        // Character moving
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if (isGrounded())
        {
            // Immediately jump once on the ground
            body.velocity = new Vector2(body.velocity.x, jump);
        }



    }

    private bool isGrounded()
    {
        //Check if the player is touching a ground layer object. If so, bool equals true.
        RaycastHit2D raycastHit = Physics2D.BoxCast(col.bounds.center, col.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

}

