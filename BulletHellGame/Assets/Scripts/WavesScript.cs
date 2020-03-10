using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesScript : MonoBehaviour {

    public GameObject leftNode;
    public GameObject rightNode;
    public GameObject centerNode;

    private WaveCarryScript leftWaveCarryScipt;
    private WaveCarryScript rightWaveCarryScipt;

    public float waveScalar = 1;


    public float waveIntensity;

    private void Awake()
    {
        leftWaveCarryScipt = leftNode.GetComponent<WaveCarryScript>();
        rightWaveCarryScipt = rightNode.GetComponent<WaveCarryScript>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        WaveScale();

        leftWaveCarryScipt.SetWave(waveIntensity);
        rightWaveCarryScipt.SetWave(waveIntensity);
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
        waveIntensity = value * waveScalar;
    }

    public void WaveScale()
    {
        centerNode.transform.localScale = new Vector3(5, 3, waveIntensity);
    }
}
