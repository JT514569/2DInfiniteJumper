using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerCheck : MonoBehaviour
{
    public InputField myText;
    [SerializeField] public string Answer;
    public bool Correct;
    public GameObject Teleporter;

    public void Check()
    {
        if (myText.text.Equals(Answer))
        {
            Debug.Log("Correct");
            Correct = true;
        }
        else
        {
            Debug.Log("Incorrect");
            Correct = false;
        }
        Time.timeScale = 1;
        Teleporter.GetComponent<Teleporter>().Teleport(Correct);
        gameObject.SetActive(false);
    }
}
