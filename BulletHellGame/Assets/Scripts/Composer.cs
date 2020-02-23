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

    void Awake()
    {
        Application.targetFrameRate = 60;
        StartCoroutine(Loop());
        
    }

    private void Start()
    {
        assetContent = asset.text;
        ReadTheLines();
    }

    // Increase the number of calls to Update.
    void Update()
    {
    }

    // Increase the number of calls to FixedUpdate.
    void FixedUpdate()
    {

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
        for (int i = 0; i < 60; i++)
        {
            List<string> textLine = textArray[i].Split(" ").ToList();
            //Debug.Log(textArray[i]);
            for(int j = 0; j < textLine.Length, j++)
            {

            }
            float num = float.Parse(textArray[i]);
            //total += num;
        }
        //Debug.Log(asset.text);
        //Debug.Log(total);
    }
}
