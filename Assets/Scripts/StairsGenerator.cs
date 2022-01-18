using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsGenerator : MonoBehaviour
{
    [SerializeField] private GameObject stairPrefab;
    [SerializeField] private Transform player;
    [SerializeField] private int startStairs = 20;

    private List<GameObject> activeStairs = new List<GameObject>();
    private float spawnPos = -4;
    private float stairLength = 1;

    void Start()
    {
        for (int i = 0; i < startStairs; i++)
            SpawnStairs();
    }

    void Update()
    {
        if (player.position.z - 4 > spawnPos - (startStairs * stairLength))
        {
            SpawnStairs();
            DeleteStair();
        }
    }

    private void SpawnStairs()
    {
        GameObject nextStair = Instantiate(stairPrefab, new Vector3(0, spawnPos, spawnPos), transform.rotation);
        activeStairs.Add(nextStair);
        spawnPos += stairLength;
    }

    private void DeleteStair()
    {
        Destroy(activeStairs[0]);
        activeStairs.RemoveAt(0);
    }
}
