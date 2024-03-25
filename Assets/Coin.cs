using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int ScoreGet;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
        {
            Score.instance.AddPoint(ScoreGet);
            gameObject.SetActive(false);
        }
    }
}
