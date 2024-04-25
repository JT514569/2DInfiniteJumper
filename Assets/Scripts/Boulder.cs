using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    Renderer render;
    public AudioClip fallSound;
    [SerializeField] private float speed = 0;
    [SerializeField] private float horizontalSpeed = 0;
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
            float movementSpeed2 = horizontalSpeed * Time.deltaTime;
            speed += -0.01f;
            transform.Translate(movementSpeed2, movementSpeed, 0);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private void OnBecomeVisible()
    {
        AudioSource.PlayClipAtPoint(fallSound, transform.position);
    }

}
