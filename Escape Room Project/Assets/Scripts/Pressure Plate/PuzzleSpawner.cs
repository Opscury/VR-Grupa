using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSpawner : MonoBehaviour
{
    public GameObject CubeSpawner;

    private void Awake()
    {
        GameObject c = Instantiate(CubeSpawner, transform.position, Quaternion.Euler(0,90,0)); 
        if (gameObject.name == "0") c.GetComponent<PuzzleRotator>().currentPlace = 0;
        if (gameObject.name == "1") c.GetComponent<PuzzleRotator>().currentPlace = 1;
        if (gameObject.name == "2") c.GetComponent<PuzzleRotator>().currentPlace = 2;
        if (gameObject.name == "3") c.GetComponent<PuzzleRotator>().currentPlace = 3;
    }
}
