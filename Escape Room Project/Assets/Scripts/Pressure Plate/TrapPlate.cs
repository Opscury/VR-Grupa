using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlate : MonoBehaviour
{
    private int targetWeight = 0;
    public GameObject destination;

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.GetComponent<Weight>() != null)
        {
            if (targetWeight == 0)
            {
                targetWeight = col.gameObject.GetComponent<Weight>().w;
                destination.GetComponent<DestinationPlate>().targetWeight = targetWeight;
            }

            if (col.gameObject.GetComponent<Weight>().w == targetWeight)
            {
                if (destination.GetComponent<DestinationPlate>().has == false)
                {
                    FindObjectOfType<Timer>().Deactivate();
                }

                if (destination.GetComponent<DestinationPlate>().has)
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
                FindObjectOfType<Timer>().active = true;
            }
        }
    }
}
