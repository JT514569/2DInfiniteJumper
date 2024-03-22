using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 3, -10);
    }
}