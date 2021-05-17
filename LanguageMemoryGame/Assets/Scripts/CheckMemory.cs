using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMemory : MonoBehaviour
{
    public MemoryController controller;
    public GameObject reverse;
    public GameObject cardView;
    public  bool isClick = false;

    private GameObject grandChild;
    private CheckMemory checkChild;

    private AudioSource audio;
    public AudioClip checkClip;
    public AudioClip winClip;
    public AudioClip loseClip;

    //public float timeToDead = 30;

    public void Start()
    {
        audio = GameObject.Find("Audio").GetComponent<AudioSource>();
    }


    public void Check()
    {
        if (!isClick)
        {

        reverse.SetActive(false);
        cardView.SetActive(true);

        

        if (controller.isFirst)
        {
            audio.clip = checkClip;
            audio.Play();

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

        audio.clip = loseClip;
        audio.Play();
        
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

        audio.clip = winClip;
        audio.Play();

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