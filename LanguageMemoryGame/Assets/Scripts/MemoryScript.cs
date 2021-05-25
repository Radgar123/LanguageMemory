using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Memory", menuName = "Memory")]
public class MemoryScript : ScriptableObject
{
    [Header("Main Card Characteristic")]
    public string tag;

    [Header("Language 1")]
    //card name in first language
    public string nameCard1;
   
    [Header("Language 2")]
    //card name in second language
    public string nameCard2;
}
