using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Memory", menuName = "Memory")]
public class MemoryScript : ScriptableObject
{
    //target word tag
    public string tag;
    //card name in first language
    public string nameCard1;
    //card name in second language
    public string nameCard2;
}
