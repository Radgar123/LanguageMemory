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
    private CheckMemory checkChild;

    public float timeToDead = 30;

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
                    Debug.Log("test");
                    /*Destroy(controller.firstObject);
                    Destroy(controller.secondObject);
                    PointController.score++;
                    controller.currentTag = null;*/
                    StartCoroutine(DestroyCards(2));
                }
                else
                {

                    StartCoroutine(DisableCards(2));
                    
                }
            }

            isClick = true;
        }

    }

    private void OnMouseUpAsButton()
    {
        Check();
    }

    IEnumerator DisableCards(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Other card");
        checkChild = controller.firstObject.GetComponent<CheckMemory>();
        checkChild.isClick = false;
        checkChild = controller.secondObject.GetComponent<CheckMemory>();
        checkChild.isClick = false;


        grandChild = controller.firstObject.transform.GetChild(0).gameObject;
        grandChild.SetActive(true);
        grandChild = controller.firstObject.transform.GetChild(1).gameObject;
        grandChild.SetActive(false);

        grandChild = controller.secondObject.transform.GetChild(0).gameObject;
        grandChild.SetActive(true);
        grandChild = controller.secondObject.transform.GetChild(1).gameObject;
        grandChild.SetActive(false);

        controller.currentTag = null;
        controller.isFirst = true;
        controller.firstObject = null;
        controller.secondObject = null;
    }

    IEnumerator DestroyCards(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(controller.firstObject);
        Destroy(controller.secondObject);
        PointController.score++;

        controller.currentTag = null;
        controller.currentTag = null;
        controller.isFirst = true;
        controller.firstObject = null;
        controller.secondObject = null;
    }

    
}