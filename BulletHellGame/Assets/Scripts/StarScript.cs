using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour {

    public float rotationSpeed = 250f;

    public float lifeTime = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));

        if (lifeTime<=0)
        {
            Destroy(gameObject);
        }
        lifeTime -= Time.deltaTime;
    }
}
