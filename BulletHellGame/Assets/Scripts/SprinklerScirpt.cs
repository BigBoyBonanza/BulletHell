using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerScirpt : MonoBehaviour {

    public float noiseGap = 1;

    public GameObject[] LeftSpawners;

    public GameObject[] RightSpawners;

    public GameObject Dot;

    public float newNum;
    public float oldNum;

    public int whichSpawner;
    public int whichSide = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (newNum < oldNum - noiseGap)
        {
            if(whichSide == 0)
            {
                whichSpawner = ChoseLeftSpawner();
                LaunchLeft();
            }
            if (whichSide == 1)
            {
                whichSpawner = ChoseRightSpawner();
                LaunchRight();
            }
            whichSide++;
            if(whichSide>1)
            {
                whichSide = 0;
            }
        }
        oldNum = newNum;
    }

    public void GetNum(float num)
    {
        newNum = num;
    }

    public int ChoseLeftSpawner()
    {
        int num = Random.Range(0, LeftSpawners.Length);
        return num;
    }

    public int ChoseRightSpawner()
    {
        int num = Random.Range(0, RightSpawners.Length);
        return num;
    }

    public void LaunchLeft()
    {
        GameObject star = Instantiate(Dot, LeftSpawners[whichSpawner].transform.position, LeftSpawners[whichSpawner].transform.rotation);
        Rigidbody rb = star.GetComponent<Rigidbody>();
        rb.AddForce(LeftSpawners[whichSpawner].transform.right * 10f, ForceMode.VelocityChange);
    }

    public void LaunchRight()
    {
        GameObject star = Instantiate(Dot, RightSpawners[whichSpawner].transform.position, RightSpawners[whichSpawner].transform.rotation);
        Rigidbody rb = star.GetComponent<Rigidbody>();
        rb.AddForce(-RightSpawners[whichSpawner].transform.right * 10f, ForceMode.VelocityChange);
        /*
        star = Instantiate(Dot, RightSpawners[whichSpawner].transform.position, RightSpawners[whichSpawner].transform.rotation);
        rb = star.GetComponent<Rigidbody>();
        rb.AddForce(-RightSpawners[whichSpawner].transform.right + ((-RightSpawners[whichSpawner].transform.forward) * 0.1f) * 10f, ForceMode.VelocityChange);
        star = Instantiate(Dot, RightSpawners[whichSpawner].transform.position, RightSpawners[whichSpawner].transform.rotation);
        rb = star.GetComponent<Rigidbody>();
        rb.AddForce(-RightSpawners[whichSpawner].transform.right + ((RightSpawners[whichSpawner].transform.forward) * 0.1f) * 10f, ForceMode.VelocityChange);
        */
    }
}
