using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersist : MonoBehaviour
{
    public static DataPersist instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Data Persists.");
        }
        instance = this;
    }
}
