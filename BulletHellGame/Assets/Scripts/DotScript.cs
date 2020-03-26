using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotScript : MonoBehaviour {

    public float lifeTime = 10f;

    public float gravityForce = 1f;

    public Rigidbody body;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(-body.transform.forward * gravityForce, ForceMode.Acceleration);
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
        lifeTime -= Time.deltaTime;
    }
}
