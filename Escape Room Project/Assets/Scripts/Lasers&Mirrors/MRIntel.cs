using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRIntel : MonoBehaviour
{
    public static MRIntel Instance;
    public List<GameObject> mirrors;

    private void Start()
    {
        Instance = this;
    }

    public void CallStartMirror(int whoRotate, int whereRotate)
    {
        mirrors[whoRotate].GetComponent<MirrorRotating>().RotateThis(whereRotate);
    }

    public void CallStopMirror(int whoRotate)
    {
        mirrors[whoRotate].GetComponent<MirrorRotating>().StopRotate();
    }
}
