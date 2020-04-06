using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLevels : MonoBehaviour {

    public float intensityScalar = 1f;
    public float intensity = 1f;

    public GameObject node1;
    public float intensityScalar1 = 1f;
    public float intensity1 = 1f;

    public GameObject node2;
    public float intensityScalar2 = 1f;
    public float intensity2 = 1f;

    public GameObject node3;
    public float intensityScalar3 = 1f;
    public float intensity3 = 1f;

    public GameObject node4;
    public float intensityScalar4 = 1f;
    public float intensity4 = 1f;

    public GameObject node5;
    public float intensityScalar5 = 1f;
    public float intensity5 = 1f;

    public GameObject node6;
    public float intensityScalar6 = 1f;
    public float intensity6 = 1f;

    public GameObject node7;
    public float intensityScalar7 = 1f;
    public float intensity7 = 1f;

    public GameObject node8;
    public float intensityScalar8 = 1f;
    public float intensity8 = 1f;

    public GameObject node9;
    public float intensityScalar9 = 1f;
    public float intensity9 = 1f;

    public GameObject node10;
    public float intensityScalar10 = 1f;
    public float intensity10 = 1f;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void FixedUpdate()
    {
        WaveScale();

    }

    public void SetIntensity(float value)
    {
        intensity = value * intensityScalar;
    }

    public void SetIntensity1(float value)
    {
        intensity1 = value * intensityScalar1;
    }

    public void SetIntensity2(float value)
    {
        intensity2 = value * intensityScalar2;
    }

    public void SetIntensity3(float value)
    {
        intensity3 = value * intensityScalar3;
    }

    public void SetIntensity4(float value)
    {
        intensity4 = value * intensityScalar4;
    }

    public void SetIntensity5(float value)
    {
        intensity5 = value * intensityScalar5;
    }

    public void SetIntensity6(float value)
    {
        intensity6 = value * intensityScalar6;
    }

    public void SetIntensity7(float value)
    {
        intensity7 = value * intensityScalar7;
    }

    public void SetIntensity8(float value)
    {
        intensity8 = value * intensityScalar8;
    }

    public void SetIntensity9(float value)
    {
        intensity9 = value * intensityScalar9;
    }

    public void SetIntensity10(float value)
    {
        {
            intensity10 = value * intensityScalar10;
        }
    }

    public void WaveScale()
    {
        node1.transform.localScale = new Vector3(3, 3, intensity1);
        node2.transform.localScale = new Vector3(3, 3, intensity2);
        node3.transform.localScale = new Vector3(3, 3, intensity3);
        node4.transform.localScale = new Vector3(3, 3, intensity4);
        node5.transform.localScale = new Vector3(3, 3, intensity5);
        node6.transform.localScale = new Vector3(3, 3, intensity6);
        node7.transform.localScale = new Vector3(3, 3, intensity7);
        node8.transform.localScale = new Vector3(3, 3, intensity8);
        node9.transform.localScale = new Vector3(3, 3, intensity9);
        node10.transform.localScale = new Vector3(3, 3, intensity10);
    }
}
