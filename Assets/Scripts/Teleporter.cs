using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject Minigame;
    public Transform Teleport1;
    public Transform Teleport2;
    public GameObject Player;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Minigame.SetActive(true);
        }
    }

    public void Teleport(bool Reward)
    {
        if (Reward == true)
        {
            Player.transform.position = Teleport1.transform.position;
        }
        else
        {
            Player.transform.position = Teleport2.transform.position;
        }
    }
}
