using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int ScoreGet;
    public AudioClip coinSound;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.AddPoint(ScoreGet);
            AudioSource.PlayClipAtPoint(coinSound, transform.position); //Creates a seperate audio source to play the sound
            Destroy(gameObject);
        }
    }
}
