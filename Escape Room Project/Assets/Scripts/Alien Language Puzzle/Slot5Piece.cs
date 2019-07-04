using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot5Piece : MonoBehaviour
{
    public GameObject logic;

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Slot 5")
        {
            logic.GetComponent<Logic>().slot5 = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Slot 5")
        {
            logic.GetComponent<Logic>().slot5 = false;
        }
    }
}
