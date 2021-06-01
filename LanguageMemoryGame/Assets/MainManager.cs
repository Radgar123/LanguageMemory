using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public int i = 0;

    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {

    }


}
