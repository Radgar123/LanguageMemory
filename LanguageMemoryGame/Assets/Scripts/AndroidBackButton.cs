using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidBackButton : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject memoryHandler;


    private bool isActive = true;

    // Update is called once per frame
    void Update()
    {
        if(Application.platform == RuntimePlatform.Android) 
        {
            if (Input.GetKeyDown(KeyCode.Escape)) 
            {
                //Application.Quit();
                Pause();
                Debug.Log("test");
            }
        }
    }

    public void Pause() 
    {
        if (isActive) 
        {
            pauseScreen.SetActive(true);
            memoryHandler.SetActive(false);
            isActive = false;
        }
        else 
        {
            pauseScreen.SetActive(false);
            memoryHandler.SetActive(true);
            isActive = true;
        }
            
    }
}
