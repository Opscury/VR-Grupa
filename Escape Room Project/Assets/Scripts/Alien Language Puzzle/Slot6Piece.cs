using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot6Piece : MonoBehaviour
{
    public GameObject logic;

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Slot 6")
        {
            logic.GetComponent<Logic>().slot6 = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Slot 6")
        {
            logic.GetComponent<Logic>().slot6 = false;
        }
    }
}
