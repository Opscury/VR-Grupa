using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot4Piece : MonoBehaviour
{
    public GameObject logic;

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Slot 4")
        {
            logic.GetComponent<Logic>().slot4 = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Slot 4")
        {
            logic.GetComponent<Logic>().slot4 = false;
        }
    }
}
