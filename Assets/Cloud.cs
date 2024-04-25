using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public List<Sprite> Clouds;
    public SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = Clouds[Random.Range(0, Clouds.Count)];
        float x = Random.Range(-9, 9);
        Vector3 poss = new Vector3(x, transform.position.y, 0);
        float size = Random.Range(1, 4);
        transform.localScale = new Vector3(size, size, 1);
        transform.position = poss;
    }
}
