using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStart : MonoBehaviour
{

    [SerializeField] private CanvasGroup UIGroup;

    [SerializeField] private bool FadeIn = false;
    [SerializeField]private bool FadeOut = false;

    void Start()
    {
        Time.timeScale = 0;
        StartCoroutine(Waiter());
        
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSecondsRealtime(1);
        Time.timeScale = 1;
        FadeOut = true;
        yield return new WaitForSecondsRealtime(1);
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (FadeIn)
        {
            if (UIGroup.alpha < 1)
            {
                UIGroup.alpha += Time.deltaTime;
                if (UIGroup.alpha >= 1)
                {
                    FadeIn = false;
                }
            }
        }

        if (FadeOut)
        {
            if (UIGroup.alpha >= 0)
            {
                UIGroup.alpha -= Time.deltaTime;
                if (UIGroup.alpha == 0)
                {
                    FadeOut = false;
                }
            }
        }
    }


}
