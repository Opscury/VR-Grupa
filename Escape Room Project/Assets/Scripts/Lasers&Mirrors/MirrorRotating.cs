using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorRotating : MonoBehaviour
{
    // Where to rotate. 0- don't rotate, 1- left, 2- right
    int RotatingTo = 0;


    void FixedUpdate()
    {
        if (RotatingTo == 1)
        {
            transform.Rotate(0, -0.1f, 0, Space.Self);
        }
        if (RotatingTo == 2)
        {
            transform.Rotate(0, 0.1f, 0, Space.Self);
        }
    }

    public void RotateThis(int whereToRotate)
    {
        RotatingTo = whereToRotate;
    }

    public void StopRotate()
    {
        RotatingTo = 0;
    }
}
