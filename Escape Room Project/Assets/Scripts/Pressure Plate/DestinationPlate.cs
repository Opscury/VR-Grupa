using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPlate : MonoBehaviour
{
    public int targetWeight;
    public bool has = false;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Weight>() != null)
        {
            if (col.gameObject.GetComponent<Weight>().w == targetWeight)
            {
                has = true;

                if(FindObjectOfType<Timer>().active == false)
                {
                    FindObjectOfType<Timer>().Finished();
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
