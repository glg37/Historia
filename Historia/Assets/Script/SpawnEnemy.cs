using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject miniBossPrefab;
    public float spawnRate;
    float timer;
    public Transform[] spawnPoints;
    public List<GameObject> enemies;
    public int maxEnemy = 5;
    private int totalSpawnedEnemies = 0;
    private bool bossSpawned = false;

    void Start()
    {
        StartCoroutine(TesTe());
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate && totalSpawnedEnemies < maxEnemy && !bossSpawned)
        {
            Spawn();
            timer = 0;
        }
        
    }
    void Spawn()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            for (int j = 0; j < 1; j++)
            {
                enemies.Add(Instantiate(enemyPrefab, spawnPoints[i].position, spawnPoints[i].rotation));
                totalSpawnedEnemies++;
            }
        }
    }
    void Spawn(int qtd)
    {
        for (int i = 0; i < qtd; i++)
        {
            if (totalSpawnedEnemies < maxEnemy)
            {
                int random = Random.Range(0, spawnPoints.Length);
                enemies.Add(Instantiate(enemyPrefab, spawnPoints[random].position, spawnPoints[random].rotation));
                totalSpawnedEnemies++;
            }
            else
            {
                break;
            }
        }
    }

   

    IEnumerator TesTe()
    {
        for (int i = 0; i < 1; i++)
        {

            yield return new WaitForSeconds(2);
        }
    }
}
