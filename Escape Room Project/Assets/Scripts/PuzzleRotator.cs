using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRotator : MonoBehaviour
{
    public List<GameObject> path;
    public int currentPlace;
    public int speed;
    public bool moving = false;

    void Update()
    {
        if(moving == false)
        {
            if (Input.GetKeyDown(KeyCode.U) && currentPlace != path.Count - 1)
            {
                currentPlace++;
                moving = true;
                Invoke("Reseto", 3);
            }
            else if (Input.GetKeyDown(KeyCode.U) && currentPlace == path.Count - 1)
            {
                currentPlace = 0;
                moving = true;
                Invoke("Reseto", 3);
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, path[currentPlace].transform.position, speed * Time.deltaTime);

    }

    public void NextPuzzle()
    {
        if(moving == false)
        {
            if (currentPlace != path.Count - 1)
            {
                currentPlace++;
                moving = true;
                Invoke("Reseto", 3);
            }
            else
            {
                currentPlace = 0;
                moving = true;
                Invoke("Reseto", 3);
            }
        }
        
    }

    private void Reseto()
    {
        moving = false;
    }
}
