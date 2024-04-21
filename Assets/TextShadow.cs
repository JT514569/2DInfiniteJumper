using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShadow : MonoBehaviour
{

    public Text scoreText;

    public Text OGText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = OGText.text;
    }
}
