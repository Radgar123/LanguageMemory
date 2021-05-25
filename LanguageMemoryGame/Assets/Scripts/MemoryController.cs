using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryController : MonoBehaviour
{
    [Header("Controll Panel about Memory")]
    public string currentTag = null;
    
    public  bool isFirst = true;
    private int numberOfClicks = 0;

    public GameObject firstObject = null;
    public GameObject secondObject = null;

    public int Clicks
    {
        get { return numberOfClicks;}
        set { numberOfClicks = value; }
    }

    
}
