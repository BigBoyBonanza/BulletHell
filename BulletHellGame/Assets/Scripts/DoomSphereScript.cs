using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomSphereScript : MonoBehaviour {

    public float lifeTime = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        //do collider thing to see if player is in it. If it is than hurt it. Otherwise, don't do shit.
    }
}
