using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System.Linq;

public class Composer : MonoBehaviour
{
    public TextAsset asset;
    private string assetContent;
    public static List<string> textArray;
    public int frameIndex = 0;

    public int target = 60;

    public GameObject deathBall;

    public AudioSource song;
    int countDown = 3;
    bool cleared = false;

    public GameObject spawner0;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;
    public GameObject spawner6;
    public GameObject spawner7;
    public GameObject spawner8;
    public GameObject spawner9;

    public GameObject Wave;
    private WavesScript waveScript;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = target;
        StartCoroutine(Loop());

        waveScript = Wave.GetComponent<WavesScript>();
    }

    private void Start()
    {
        assetContent = asset.text;
        //ReadTheLines();
        Debug.Log(spawner0.transform.position);
        song.Play();
    }

    // Increase the number of calls to Update.
    void Update()
    {
        if(target != Application.targetFrameRate)
        {
            Application.targetFrameRate = target;
        }
    }

    // Increase the number of calls to FixedUpdate.
    void FixedUpdate()
    {
        /*
        if(cleared)
        {
            ReadALine(frameIndex);
            frameIndex++;
        }
        */
    }

    IEnumerator Loop()
    {
        while (true)
        {
            /*
            yield return new WaitForSeconds(1);
            countDown--;
            if(countDown == 0)
            {
                cleared = true;
                song.Play();
            }
            */
            yield return new WaitForFixedUpdate();
            ReadALine(frameIndex);
            frameIndex++;
        }
    }

    private void ReadTheLines()
    {
        //float total = 0;
        textArray = assetContent.Split('\n').ToList();
        for (int i = 0; i < textArray.Count(); i++)
        {
            Debug.Log("New Row");
            List<string> textLine = textArray[i].Split(' ').ToList();
            int size = textLine.Count();
            for(int j = 0; j < size; j++)
            {
                float num = float.Parse(textLine[j]);
                //Debug.Log(num);
                //total += num;
            }
        }
        //Debug.Log(asset.text);
        //Debug.Log(total);
    }

    private void ReadALine(int index)
    {
        textArray = assetContent.Split('\n').ToList();
        List<string> textLine = textArray[index].Split(' ').ToList();
        int size = textLine.Count();
        for (int j = 0; j < size; j++)
        {
            float num = float.Parse(textLine[j]);
            //Debug.Log(num);
            //total += num;
            //high noises to low noises
            if(j == 0)
            {
                /*
                if(num > 6)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner0.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner0.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
            if (j == 1)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner1.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner1.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
            if (j == 2)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner2.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner2.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
            if (j == 3)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner3.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner3.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
            if (j == 4)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner4.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner4.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
            if (j == 5)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner5.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner5.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
            if (j == 6)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner6.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner6.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
            if (j == 7)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner7.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner7.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
            if (j == 8)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner8.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner8.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
                waveScript.SetWave(num);
            }
            if (j == 9)
            {
                /*
                if (num > 8)
                {
                    GameObject doomSphere = Instantiate(deathBall, spawner9.transform);
                    Rigidbody rb = doomSphere.GetComponent<Rigidbody>();
                    rb.AddForce(spawner9.transform.forward * 50f, ForceMode.VelocityChange);
                }
                */
            }
        }
    }
}
