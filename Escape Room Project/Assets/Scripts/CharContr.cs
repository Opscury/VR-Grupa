using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharContr : MonoBehaviour
{
    public float movementSpeed;
    public GameObject LaserPrefab;

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
        }
        else if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }


        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
    

        if (Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -5, 0, Space.Self);
        }
        else if (Input.GetKey(KeyCode.E) && !Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 5, 0, Space.Self);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject Laser = Instantiate(LaserPrefab, transform.position, transform.rotation);
        }
    }
}
