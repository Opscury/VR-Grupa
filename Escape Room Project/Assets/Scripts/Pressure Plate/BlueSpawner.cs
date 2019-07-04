using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpawner : MonoBehaviour
{
    public GameObject indiana;

    private void Awake()
    {
        Instantiate(indiana, transform.position, Quaternion.Euler(0,45,0));
    }
}
