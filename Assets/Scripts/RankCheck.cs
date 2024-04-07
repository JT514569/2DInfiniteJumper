using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankCheck : MonoBehaviour
{
    public static Animator anim;
    [SerializeField] public int ScoreC;
    [SerializeField] public int ScoreB;
    [SerializeField] public int ScoreA;
    [SerializeField] public int ScoreS;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Awake()
    {
        StartCoroutine(Ranking());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Ranking()
    {
        yield return new WaitUntil(() => Score.instance.score >= ScoreC);
        anim.SetInteger("Rank", 1);
        yield return new WaitUntil(() => Score.instance.score >= ScoreB);
        anim.SetInteger("Rank", 2);
        yield return new WaitUntil(() => Score.instance.score >= ScoreA);
        anim.SetInteger("Rank", 3);
        yield return new WaitUntil(() => Score.instance.score >= ScoreS);
        anim.SetInteger("Rank", 4);

    }
}
