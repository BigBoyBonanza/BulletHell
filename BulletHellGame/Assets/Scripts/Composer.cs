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

    void Awake()
    {
        Application.targetFrameRate = 60;
        StartCoroutine(Loop());
        
    }

    private void Start()
    {
        assetContent = asset.text;
        //ReadTheLines();
    }

    // Increase the number of calls to Update.
    void Update()
    {
    }

    // Increase the number of calls to FixedUpdate.
    void FixedUpdate()
    {
        ReadALine(frameIndex);
        frameIndex++;
    }

    IEnumerator Loop()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            
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
            Debug.Log(num);
            //total += num;
            if(j == 0)
            {

            }
            if (j == 1)
            {

            }
            if (j == 2)
            {

            }
            if (j == 3)
            {

            }
            if (j == 4)
            {

            }
            if (j == 5)
            {

            }
            if (j == 6)
            {

            }
            if (j == 7)
            {

            }
            if (j == 8)
            {

            }
            if (j == 9)
            {

            }
        }
    }
}
