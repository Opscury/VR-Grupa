using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCube : MonoBehaviour
{
    public int w;

    private void Awake()
    {
        w = Random.Range(2, 15);
        transform.localScale = new Vector3(w, w, w);
        //gameObject.AddComponent<BoxCollider>();
        FindObjectOfType<GoldenCubeSpawner>().cubeW.Add(w);
        //gameObject.AddComponent<OVRGrabbable>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Top")
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
