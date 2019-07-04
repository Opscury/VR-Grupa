using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPlate : MonoBehaviour
{
    public int targetWeight;
    public GameObject screen;
    public bool has = false;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Weight>() != null)
        {
            if (col.gameObject.GetComponent<Weight>().w == targetWeight)
            {
                has = true;

                if(screen.GetComponent<Timer>().active == false)
                {
                    screen.GetComponent<Timer>().Finished();
                }
            }
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.GetComponent<Weight>() != null)
        {
            if (col.gameObject.GetComponent<Weight>().w == targetWeight)
            {
                has = false;
            }
        }
    }
}
