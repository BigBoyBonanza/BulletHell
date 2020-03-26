using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawningScript : MonoBehaviour {

    public float noiseGap = 1;

    public GameObject[] Spawners;

    public GameObject Star;

    public float newNum;
    public float oldNum;

    public int whichSpawner;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(newNum < oldNum - noiseGap)
        {
            whichSpawner = ChoseSpawner();
            Launch();
        }
        oldNum = newNum;
	}

    public void GetNum(float num)
    {
        newNum = num;
    }

    public int ChoseSpawner()
    {
        int num = Random.Range(0, Spawners.Length);
        return num;
    }

    public void Launch()
    {
        GameObject star = Instantiate(Star, Spawners[whichSpawner].transform.position, Spawners[whichSpawner].transform.rotation);
        Rigidbody rb = star.GetComponent<Rigidbody>();
        rb.AddForce(-Spawners[whichSpawner].transform.forward * 10f, ForceMode.VelocityChange);
    }
}
