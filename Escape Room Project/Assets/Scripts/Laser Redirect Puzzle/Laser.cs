using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public int distance;

    public string bounceTag;

    public LineRenderer line;

    private void Awake()
    {
        line = line.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        Vector3 direction = transform.forward;
        //Vector3 startPosition = 

    }
}
