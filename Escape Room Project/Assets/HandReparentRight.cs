using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandReparentRight : MonoBehaviour
{
    // Resets the parent after load so handtracking works properly
    void Start()
    {
        Invoke("SetParent", 1);
    }

    private void SetParent()
    {
        transform.SetParent(GameObject.Find("hand_right").transform);
    }
}
