using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationSpawner : MonoBehaviour
{
    public GameObject cubeDestination;

    private void Awake()
    {
        Instantiate(cubeDestination, transform.position, Quaternion.identity);
    }
}
