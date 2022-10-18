using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy1Prefab;
    [SerializeField]
    private GameObject enemy2Prefab;
    [SerializeField]
    private GameObject enemy3Prefab;

    [SerializeField]
    private float enemy1Interval = 3.5f;
    [SerializeField]
    private float enemy2Interval = 4.0f;
    [SerializeField]
    private float enemy3Interval = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy1Interval, enemy1Prefab));
        StartCoroutine(spawnEnemy(enemy2Interval, enemy2Prefab));
        StartCoroutine(spawnEnemy(enemy3Interval, enemy3Prefab));
    }

   private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
