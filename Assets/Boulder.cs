using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    Renderer render;
    [SerializeField] private float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (render.isVisible)
        {
            float movementSpeed = speed * Time.deltaTime;
            speed += -0.01f;
            transform.Translate(0, movementSpeed, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
