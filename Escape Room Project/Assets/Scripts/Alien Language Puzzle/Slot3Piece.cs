using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot3Piece : MonoBehaviour
{
    public GameObject logic;

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Slot 3")
        {
            logic.GetComponent<Logic>().slot3 = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Slot 3")
        {
            logic.GetComponent<Logic>().slot3 = false;
        }
    }
}
