using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftButtonUp : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        FindObjectOfType<LiftMoving>().LiftUp();
    }
}
