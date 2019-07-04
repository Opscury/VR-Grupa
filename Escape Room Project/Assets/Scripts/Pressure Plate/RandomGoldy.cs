using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGoldy : MonoBehaviour
{
    public int w;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Top")
        {
            gameObject.transform.SetParent(col.gameObject.transform);
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Top")
        {
            gameObject.transform.SetParent(gameObject.transform);
        }
    }
}
