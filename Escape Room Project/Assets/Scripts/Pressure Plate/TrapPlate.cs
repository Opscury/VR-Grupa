using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlate : MonoBehaviour
{
    private int targetWeight = 0;

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.GetComponent<Weight>() != null)
        {
            if (targetWeight == 0)
            {
                targetWeight = col.gameObject.GetComponent<Weight>().w;
                FindObjectOfType<DestinationPlate>().targetWeight = targetWeight;
            }

            if (col.gameObject.GetComponent<Weight>().w == targetWeight)
            {
                if (FindObjectOfType<DestinationPlate>().has == false)
                {
                    FindObjectOfType<Timer>().Deactivate();
                }

                if (FindObjectOfType<DestinationPlate>().has)
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
