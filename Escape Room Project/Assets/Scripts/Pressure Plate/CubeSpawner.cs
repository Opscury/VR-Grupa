using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject SpawnPoint3;

    public GameObject RandomCube;

    private void Awake()
    {
        Instantiate(RandomCube, SpawnPoint1.transform.position, Quaternion.identity);
        Instantiate(RandomCube, SpawnPoint2.transform.position, Quaternion.identity);
        Instantiate(RandomCube, SpawnPoint3.transform.position, Quaternion.identity);
    }
}
