using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveCarryScript : MonoBehaviour {

    public GameObject nextNode;

    public float waveIntensity;

    private WaveCarryScript nextWaveCarryScipt;

    public bool end = false;

    private void Awake()
    {

        if (!end)
        {

            nextWaveCarryScipt = nextNode.GetComponent<WaveCarryScript>();
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        WaveScale();
        if(!end)
        {
            nextWaveCarryScipt.SetWave(waveIntensity);
        }
    }

    IEnumerator Loop()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            //ReadALine(frameIndex);
            //frameIndex++;



            //gets told a value each frame/time period
            //scales z value of first index by that value
            //that value will  tell next left and right paths if it's the start
            //the node will tell the next one what value it has to be before it gets a new one.

        }
    }

    public void SetWave(float value)
    {
        waveIntensity = value;
    }

    public void WaveScale()
    {
        gameObject.transform.localScale = new Vector3(5, 3, waveIntensity);
    }
}
