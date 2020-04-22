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
    public int frameCap = 0;

    public int target = 60;

    public AudioSource song;
    int countDown = 3;
    bool cleared = false;
    
    public GameObject Wave;
    private WavesScript waveScript;

    public GameObject Tide;
    private TideScript tideScript;

    public GameObject Falling;
    private StarSpawningScript starSpawningScript;

    public GameObject Sprink;
    private SprinklerScirpt sprinklerScipt;

    public GameObject Levels;
    private DebugLevels debugLevelsScript;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = target;
        StartCoroutine(Loop());

        waveScript = Wave.GetComponent<WavesScript>();
        tideScript = Tide.GetComponent<TideScript>();
        starSpawningScript = Falling.GetComponent<StarSpawningScript>();
        sprinklerScipt = Sprink.GetComponent<SprinklerScirpt>();
        debugLevelsScript = Levels.GetComponent<DebugLevels>();
    }

    private void Start()
    {
        assetContent = asset.text;

        textArray = assetContent.Split('\n').ToList();
        frameCap = textArray.Count();
        //ReadTheLines();
        //Debug.Log(spawner0.transform.position);
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
            if(frameIndex <= frameCap)
            {
                frameIndex++;
            }
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
        //textArray = assetContent.Split('\n').ToList();
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
                debugLevelsScript.SetIntensity1(num);
            }
            if (j == 1)
            {
                debugLevelsScript.SetIntensity2(num);
                //waveScript.SetWave(num);
            }
            if (j == 2)
            {
                debugLevelsScript.SetIntensity3(num);
            }
            if (j == 3)
            {
                debugLevelsScript.SetIntensity4(num);
            }
            if (j == 4)
            {
                debugLevelsScript.SetIntensity5(num);
            }
            if (j == 5)
            {
                debugLevelsScript.SetIntensity6(num);
            }
            if (j == 6)
            {
                debugLevelsScript.SetIntensity7(num);
                //sprinklerScipt.GetNum(num);
            }
            if (j == 7)
            {
                debugLevelsScript.SetIntensity8(num);
            }
            if (j == 8)
            {
                debugLevelsScript.SetIntensity9(num);
            }
            if (j == 9)
            {
                debugLevelsScript.SetIntensity10(num);
                //tideScript.SetWave(num);
                //starSpawningScript.GetNum(num);
            }
        }
    }
}
