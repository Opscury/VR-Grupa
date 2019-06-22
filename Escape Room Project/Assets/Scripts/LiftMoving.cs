using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftMoving : MonoBehaviour
{
    public List<GameObject> path;
    public int currentPlace = 1;
    //movingWhere- where to move. If 0 then nowhere, 1 downwards, 2 upwards
    int movingWhere = 0;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentPlace != path.Count-1)
        {
            movingWhere = 2;
            currentPlace++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && currentPlace != 0)
        {
            movingWhere = 1;
            currentPlace--;
        }

        if(movingWhere == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, path[currentPlace].transform.position, speed * Time.deltaTime);
        } else if (movingWhere == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, path[currentPlace].transform.position, speed * Time.deltaTime);
        }
    }
}
