using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public int speed = 500;
    public int lifeTime = 5;
    Rigidbody rb;
    // Start is called before the first frame update
    IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
     
    void Start()
    {
        StartCoroutine(DeathTimer());
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.AddForce(transform.forward * speed);
    }

   /*private void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.LookAt(newPosition);
        transform.Translate(newPosition, Space.World);
    } */
}
