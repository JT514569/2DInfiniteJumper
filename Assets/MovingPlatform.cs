using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform PosA;
    public Transform PosB;
    Vector2 targetPos;
    public int MoveSpeed;





    // Start is called before the first frame update
    void Start()
    {
        transform.position = PosA.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, PosA.position) < 0.02f)
        {
            targetPos = PosB.position;
        }
        if (Vector2.Distance(transform.position, PosB.position) < 0.02f)
        {
            targetPos = PosA.position;
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, MoveSpeed * Time.deltaTime);
    }
}
