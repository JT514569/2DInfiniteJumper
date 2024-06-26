using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEditor;
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
    private bool invincible = false;
    public GameObject PostProcess;
    

    [SerializeField] private AudioSource hurtSound;
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private float Invulnerability;
    [SerializeField] private float InvinFlashes;
    [SerializeField] private float InvinSeconds;
    public SpriteRenderer spriteRend;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        col = GetComponent<BoxCollider2D>();

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
            transform.localScale = new Vector3(0.5f, 0.5f, 1);

        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-0.5f, 0.5f, 1);

        // Character moving
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if (isGrounded())
        {
            // Immediately jump once on the ground
            body.velocity = new Vector2(body.velocity.x, jump);
            anim.SetTrigger("Jump");
            jumpSound.Play();
        }



    }

    private bool isGrounded()
    {
        //Check if the player is touching a ground layer object. If so, bool equals true.
        RaycastHit2D raycastHit = Physics2D.BoxCast(col.bounds.center, col.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    public void Damage(int _damage)
    {
        if (!invincible)
        {
            StartCoroutine(Invulnerable());
            hurtSound.Play();
            Score.instance.AddPoint(_damage * -1);
        }

    }

    private IEnumerator Invulnerable()
    {
        invincible = true;
        Physics2D.IgnoreLayerCollision(10, 11, true);


        for (int i = 0; i < InvinFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            PostProcess.SetActive(true);
            yield return new WaitForSeconds(InvinSeconds);
            spriteRend.color = Color.white;
            PostProcess.SetActive(false);
            yield return new WaitForSeconds(InvinSeconds);
        }
        //Invulnerableness
        Physics2D.IgnoreLayerCollision(10, 11, false);
        invincible = false;
    }

}

