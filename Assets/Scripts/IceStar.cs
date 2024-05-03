using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceStar : MonoBehaviour
{
    public Renderer render;
    public GameObject Halves;
    public AudioClip fallSound;
    [SerializeField] private float speed = -0.01f;
    [SerializeField] private float lifetime;

    // Update is called once per frame
    void Update()
    {
        if (render.isVisible)
        {
            float movementSpeed = speed * Time.deltaTime;
            speed += -0.01f;
            transform.Translate(0, movementSpeed, 0);
            if ((speed * -1) > lifetime)
            {
                render.enabled = false;
                Halves.SetActive(true);
            }


        }
    }

    private void OnBecomeVisible()
    {
        AudioSource.PlayClipAtPoint(fallSound, transform.position);
    }
}
