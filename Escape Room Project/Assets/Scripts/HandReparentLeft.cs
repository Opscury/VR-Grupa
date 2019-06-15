using UnityEngine;

public class HandReparentLeft : MonoBehaviour
{
    // Resets the parent after load so handtracking works properly
    void Start()
    {
        Invoke("SetParent", 1);
    }

    private void SetParent()
    {
        transform.SetParent(GameObject.Find("hand_left").transform);
    }
}
