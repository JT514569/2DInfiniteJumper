using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggerer : MonoBehaviour
{
    public bool oneShot = false;
    private bool alreadyEntered = false;
    private bool alreadyExited = false;

    public string CollisionTag;

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (alreadyEntered)
            return;

        if (!string.IsNullOrEmpty(CollisionTag) && !collision.CompareTag(CollisionTag))
            return;

        onTriggerEnter.Invoke();

        if (oneShot)
            alreadyEntered = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (alreadyExited)
            return;

        if (!string.IsNullOrEmpty(CollisionTag) && !collision.CompareTag(CollisionTag))
            return;

        onTriggerExit.Invoke(); 

        if (oneShot)
            alreadyExited = true;
    }
}
