using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTeleport : MonoBehaviour
{
    public Text myText;     // drag your text object on here

    public void ClickLetter(string letterClicked)
    {
        string tempCurString = myText.text;

        string tempNewString = tempCurString + letterClicked;
        myText.text = tempNewString;
    }
}
