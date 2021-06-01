using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnController : MonoBehaviour
{

    [Header("Memory configuration")]

    private int numberOfPair;

    public List<MemoryScript> memory;
    public List<GameObject> spawnPoints;

    private TextMeshProUGUI grandChild;
    private GameObject objectChild;

    [Header("Primary operatio on Cards")]
    public List<GameObject> cardTransformList;

    private void Awake()
    {
        SpawnPairs();
    }

    // Start is called before the first frame update
    void Start()
    {
        RevelCards();
        //StartCoroutine(DisplayCardsForWhile());
        Debug.Log("Hello World");
    }

    public void SpawnCards()
    {
        
        int cardID = Random.Range(0, memory.Count);
        int spawnPointsID = Random.Range(0, spawnPoints.Count);

        spawnPoints[spawnPointsID].tag = memory[cardID].tag;
        grandChild = spawnPoints[spawnPointsID].transform.GetChild(1).GetChild(0).GetChild(0).transform.GetComponent<TextMeshProUGUI>();
        grandChild.text = memory[cardID].nameCard1;
        spawnPoints.Remove(spawnPoints[spawnPointsID]);

        spawnPointsID = Random.Range(0, spawnPoints.Count);
        spawnPoints[spawnPointsID].tag = memory[cardID].tag;
        grandChild = spawnPoints[spawnPointsID].transform.GetChild(1).GetChild(0).GetChild(0).transform.GetComponent<TextMeshProUGUI>();
        grandChild.text = memory[cardID].nameCard2;

        spawnPoints.Remove(spawnPoints[spawnPointsID]);
        memory.Remove(memory[cardID]);
    }

    public void SpawnPairs()
    {
        numberOfPair = spawnPoints.Count / 2;

        for (int i = 0; i < numberOfPair; i++)
        {
            SpawnCards();
        }

        SpawnCards();
    }

   private void RevelCards()
   {
        
        for (int i = 0; i < cardTransformList.Count; i++)
        {
            Destroy(cardTransformList[i]);
        }

        Debug.Log("Nie œmiga");
        
    }

   IEnumerator DisplayCardsForWhile()
   {
        yield return new WaitForSeconds(5);

        /*foreach(GameObject card in spawnPoints)
        {
            objectChild = card.transform.GetChild(0).gameObject;
            objectChild.SetActive(true);

            objectChild = card.transform.GetChild(1).gameObject;
            objectChild.SetActive(false);

        }*/

        for(int i = 0; i < cardTransformList.Count; i++)
        {
            objectChild = spawnPoints[i].transform.GetChild(0).gameObject;
            objectChild.SetActive(true);

            objectChild = spawnPoints[i].transform.GetChild(1).gameObject;
            objectChild.SetActive(false);
        }
    }

    
}
