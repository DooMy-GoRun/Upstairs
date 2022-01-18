using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefab;
    [SerializeField] private Transform player;
    [SerializeField] private int startEnemy = 5;

    private List<GameObject> activeEnemy = new List<GameObject>();
    private float spawnPos = 11;
    private float spawnPosWithRandom;

    void Start()
    {
        spawnPosWithRandom = spawnPos + Random.Range(0, 3);

        for (int i = 0; i < startEnemy; i++)
            SpawnEnemy();
    }

    void Update()
    {
        spawnPos = player.position.z + 11f;
        spawnPosWithRandom = spawnPos + Random.Range(0, 3);

        if (player.position.z - 2 > activeEnemy[0].transform.position.z)
        {
            //enemyTransform[numberEnemy].position = new Vector3(0, spawnPos, spawnPos);
            SpawnEnemy();
            DeleteEnemy();
        }
    }

    private void SpawnEnemy()
    {
        GameObject nextEnemy = Instantiate(enemyPrefab[Random.Range(0,3)], new Vector3(Random.Range(-3, 4), spawnPosWithRandom, spawnPosWithRandom), transform.rotation);
        activeEnemy.Add(nextEnemy);
    }

    private void DeleteEnemy()
    {
        Destroy(activeEnemy[0]);
        activeEnemy.RemoveAt(0);
    }
}
