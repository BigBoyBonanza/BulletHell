using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawningScript : MonoBehaviour {

    public GameObject[] Spawners;

    public GameObject Star;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ChoseSpawner()
    {

    }

    public void Launch(GameObject spawner)
    {
        GameObject star = Instantiate(Star, spawner.transform.position, spawner.transform.rotation);
        Rigidbody rb = star.GetComponent<Rigidbody>();
        rb.AddForce(spawner.transform.forward * 40f, ForceMode.VelocityChange);
    }
}
