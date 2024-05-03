using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    SpriteRenderer render;
    [SerializeField] private float speed;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (render.isVisible)
        {
            float movementSpeed = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, movementSpeed);
            this.render.flipX = player.transform.position.x > this.transform.position.x;


        }
    }
}
