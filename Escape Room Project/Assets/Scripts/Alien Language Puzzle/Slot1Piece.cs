using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot1Piece : MonoBehaviour
{
    public GameObject logic;

    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "Slot 1")
        {
            logic.GetComponent<Logic>().slot1 = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Slot 1")
        {
            logic.GetComponent<Logic>().slot1 = false;
        }
    }
}
