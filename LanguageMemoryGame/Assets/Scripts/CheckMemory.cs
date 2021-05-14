using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMemory : MonoBehaviour
{
    public MemoryController controller;
    public GameObject reverse;
    public GameObject cardView;
    public  bool isClick = false;
    private AudioSource memoryCardClickAudio;

    private GameObject grandChild;

    public float timeToDead;

    public void Start()
    {
        memoryCardClickAudio = GetComponent<AudioSource>();
    }


    public void Check()
    {
        if (!isClick)
        {

        reverse.SetActive(false);
        cardView.SetActive(true);

        

        if (controller.isFirst)
        {
            controller.currentTag = gameObject.tag;
            controller.isFirst = false;
            controller.firstObject = gameObject;

        }
        else
        {
                controller.secondObject = gameObject;

                if (controller.currentTag == gameObject.tag)
                {
                   
                    reverse.SetActive(false);
                    cardView.SetActive(true);
                    ExampleCoroutine();
                    Debug.Log("test");
                    Destroy(controller.firstObject);
                    Destroy(controller.secondObject);
                }
                else if(controller.currentTag != gameObject.tag)
                {
                    

                    Debug.Log("Other card");

                    //StartCoroutine(ExampleCoroutine());

                    

                    //while()
                }
            }

        isClick = true;
        }

    }

    private void OnMouseUpAsButton()
    {
        Check();
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(30);
        
    }

}