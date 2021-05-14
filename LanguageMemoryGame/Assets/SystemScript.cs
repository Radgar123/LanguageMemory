using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SystemScript : MonoBehaviour
{
    public TextMeshProUGUI grandChild;

    // Start is called before the first frame update
    void Start()
    {
        grandChild = this.gameObject.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        Debug.Log(grandChild);
        grandChild.text = "fiut";
    }

    
}
