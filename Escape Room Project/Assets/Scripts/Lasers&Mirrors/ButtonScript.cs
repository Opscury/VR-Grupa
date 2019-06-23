using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    bool AlreadyRotating = false;
    public int whoRotate;
    public int whereRotate = 0;
    public void Rotating()
    {
        if(AlreadyRotating == false)
        {
            MRIntel.Instance.CallStartMirror(whoRotate, whereRotate);
            AlreadyRotating = true;
        } else
        {
            MRIntel.Instance.CallStopMirror(whoRotate);
            AlreadyRotating = false;
        }
    }
}
