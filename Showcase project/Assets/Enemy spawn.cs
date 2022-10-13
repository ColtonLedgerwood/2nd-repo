using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawn : MonoBehaviour
{
    public static Enemyspawn instantce;
    void Awake() { instantce = this;}
    //Enemy Prefabs
    public List<GameObject> prefabs;
    //Enemy spawn root points
    public List<Transform> spawnPoints;
    //Enemy spawn interval
    public float spawnInterval = 2f;


    public void StartSpawning()
    {
        //Call the spawn coroutine
        StartCoroutine(SpawnDelay());
    }

    IEnumerator SpawnDelay()
    {
        //Call the spawn method
        SpawnEnemy();
        //wait spawn interval
        yield return new WaitForSeconds(spawnInterval);
        //Recall the same coroutine
        StartCoroutine(SpawnDelay());
    }

    void SpawnEnemy()
    {
        //Randomize the enemy spawned
        int randomPrefabID = Random.Range(0, prefabs.Count);
        //Randomize the spawn point 
        int randomSpawnPointID = Random.Range(0, spawnPoints.Count);
        //Instantiate the enemy prefab
        GameObject spawnedEnemy = Instantiate(prefabs[randomPrefabID], spawnPoints[randomSpawnPointID]);
    }
}
