using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftButtonDown : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        FindObjectOfType<LiftMoving>().LiftDown();
    }
}
