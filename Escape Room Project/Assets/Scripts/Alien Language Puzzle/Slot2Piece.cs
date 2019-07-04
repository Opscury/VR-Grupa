using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot2Piece : MonoBehaviour
{
    public GameObject logic;

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Slot 2")
        {
            logic.GetComponent<Logic>().slot2 = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Slot 2")
        {
            logic.GetComponent<Logic>().slot2 = false;
        }
    }
}
