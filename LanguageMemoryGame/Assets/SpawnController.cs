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

    // Start is called before the first frame update
    void Start()
    {
        numberOfPair = spawnPoints.Count / 2;
        SpawnPairs();
    }

    public void SpawnCards()
    {
        int cardID = Random.Range(0, memory.Count);
        int spawnPointsID = Random.Range(0, spawnPoints.Count);

        spawnPoints[spawnPointsID].tag = memory[cardID].tag;
        grandChild = spawnPoints[spawnPointsID].transform.GetChild(1).GetChild(0).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        grandChild.text = memory[cardID].nameCard1;
        spawnPoints.Remove(spawnPoints[spawnPointsID]);

        spawnPointsID = Random.Range(0, spawnPoints.Count);
        spawnPoints[spawnPointsID].tag = memory[cardID].tag;
        grandChild = spawnPoints[spawnPointsID].transform.GetChild(1).GetChild(0).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
        grandChild.text = memory[cardID].nameCard2;

        spawnPoints.Remove(spawnPoints[spawnPointsID]);
        memory.Remove(memory[cardID]);
    }

    public void SpawnPairs()
    {
        for(int i = 0; i < numberOfPair; i++)
        {
            SpawnCards();
        }

        
    }

    public void SpawnOneElement()
    {
        int cardID = Random.Range(0, memory.Count);
        int spawnPointsID = Random.Range(0, spawnPoints.Count);
        
    }
}
