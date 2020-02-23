using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float distance = 36.0f;

    /*
    private Rigidbody rb;
    private float moveSpeed = 100f;
    public Vector3 direction;
    */

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        /*
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = distance;
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector3(direction.x * moveSpeed, mousePosition.z, direction.y * moveSpeed);
            //transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        }

        else
        {
            rb.velocity = Vector3.zero;
        }
        */
    }
}
