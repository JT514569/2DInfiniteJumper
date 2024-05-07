using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFlag : MonoBehaviour
{
    public GameObject Winner;
    public GameObject InstaRestart;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Winner.SetActive(true);
            InstaRestart.SetActive(false);
        }
    }
}
