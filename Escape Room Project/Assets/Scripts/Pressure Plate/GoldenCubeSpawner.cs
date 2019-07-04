using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenCubeSpawner : MonoBehaviour
{
    public GameObject goldy;

    public List<int> cubeW = new List<int>();

    private void Start()
    {
        int r = Random.Range(0, cubeW.Count);
        GameObject g = Instantiate(goldy, transform.position, Quaternion.identity);
        g.GetComponent<RandomGoldy>().w = cubeW[r];
        g.transform.localScale = new Vector3(g.GetComponent<RandomGoldy>().w, g.GetComponent<RandomGoldy>().w, g.GetComponent<RandomGoldy>().w);
        //g.gameObject.AddComponent<BoxCollider>();
        g.transform.position = transform.position;
        //g.gameObject.AddComponent<OVRGrabbable>();
    }

    


}
