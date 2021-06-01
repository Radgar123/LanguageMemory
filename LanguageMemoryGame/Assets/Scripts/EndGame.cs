using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject endGame;
    private GameObject MemoryHandler;

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        MemoryHandler = GameObject.Find("MemoryHandler");
    }

    // Update is called once per frame
    void Update()
    {
        CheckNumberOfDestroyedCards();
    }

    void CheckNumberOfDestroyedCards() 
    {
        if(PointController.actualCards >= 8) 
        {
            endGame.SetActive(true);
            Destroy(MemoryHandler);
        }
    }

    public void LoadLevel() 
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("test");
    }

    public void ExitToMenu() 
    {
        SceneManager.LoadScene("Menu");
    }

}
