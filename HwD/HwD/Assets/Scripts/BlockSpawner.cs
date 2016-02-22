using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockSpawner : MonoBehaviour
{
    public GameObject block;
    public float elapsedTime;
    public float spawnDelay;
    public Vector3 spawnPoint;
    public Vector2 spawnDelayRange;
    // Use this for initialization
    void Start ()
    {
        spawnDelay = Random.Range(spawnDelayRange.x, spawnDelayRange.y);
    }

    // Update is called once per frame
    void Update ()
    {
        if (Managers.GameManager.gameState == "Play")
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= spawnDelay)
            {
                SpawnBlock(Random.Range(1, 3));
                elapsedTime = 0f;
                spawnDelay = Random.Range(spawnDelayRange.x, spawnDelayRange.y);
            }
        }
        if (Managers.GameManager.gameState == "Reset")
        {
            elapsedTime = 0;
        }
    }

    void SpawnBlock(int amt)
    {
        List<int> offsetList = new List<int> { -1, 0, 1 };
        for (int i = 0; i < amt; i++)
        {
            int laneOffset = offsetList[Random.Range(0,offsetList.Count)];
            Instantiate(block, spawnPoint + new Vector3(laneOffset,0,0), Quaternion.identity);
            offsetList.Remove(laneOffset);
        }
    }
}
