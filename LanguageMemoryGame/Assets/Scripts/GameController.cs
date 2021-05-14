using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Memory configuration")]
    private int numberOfPair;
    public List<GameObject> arrayOfFirstMemory;
    public List<GameObject> arrayOfSecondMemory;
    public List<Transform> spawnPoints;


    // Start is called before the first frame update
    void Start()
    {
        numberOfPair = spawnPoints.Count / 2;
        SpawnPairs();
        SpawnOneFirstElement();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnCards()
    {
        int cardID = Random.Range(0, arrayOfFirstMemory.Count);
        int spawnPointsID = Random.Range(0, spawnPoints.Count);
        Instantiate(arrayOfFirstMemory[cardID], spawnPoints[spawnPointsID].position, spawnPoints[spawnPointsID].rotation);
        arrayOfFirstMemory.Remove(arrayOfFirstMemory[cardID]);
        spawnPoints.Remove(spawnPoints[spawnPointsID]);
        spawnPointsID = Random.Range(0, spawnPoints.Count);
        Instantiate(arrayOfSecondMemory[cardID], spawnPoints[spawnPointsID].position, spawnPoints[spawnPointsID].rotation);
        arrayOfSecondMemory.Remove(arrayOfSecondMemory[cardID]);
        spawnPoints.Remove(spawnPoints[spawnPointsID]);
    }

    public void SpawnOneFirstElement()
    {
        int cardID = Random.Range(0, arrayOfFirstMemory.Count);
        int spawnPointsID = Random.Range(0, spawnPoints.Count);
        Instantiate(arrayOfFirstMemory[cardID], spawnPoints[spawnPointsID].position, spawnPoints[spawnPointsID].rotation);
    }

    public void SpawnOneSecondElement()
    {

    }

    public void SpawnPairs()
    {
        for(int i = 0; i < numberOfPair; i++)
        {
            SpawnCards();
        }
    }


}
