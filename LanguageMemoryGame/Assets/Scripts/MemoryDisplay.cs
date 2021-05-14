using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MemoryDisplay : MonoBehaviour
{
    public MemoryScript memory;

    public TextMeshProUGUI cardText;

    public static  string memoryTag;

    //private SpriteRenderer cardBackground;
    //public Color cardBackgroundColor = Color.white;

    public void Start()
    {
        gameObject.tag = memory.tag;
        memoryTag = gameObject.tag;
        cardText.text = "" + memory.name;
    }
}
