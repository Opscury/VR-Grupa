using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftMoving : MonoBehaviour
{
    public List<GameObject> path;
    public int dir;
    public int currentPlace = 0;
    public int speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && currentPlace != path.Count-1)
        {
            dir = 1;
            currentPlace++;
        }
        if (Input.GetKeyDown(KeyCode.P) && currentPlace != 0)
        {
            dir = 2;
            currentPlace--;
        }

        transform.position = Vector3.MoveTowards(transform.position, path[currentPlace].transform.position, speed * Time.deltaTime);
        
    }

    public void LiftUp()
    {
        if (currentPlace != path.Count - 1)
        {
            dir = 1;
            currentPlace++;
        }
    }

    public void LiftDown()
    {
        if (currentPlace != 0)
        {
            dir = 2;
            currentPlace--;
        }  
    }
}
