using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    void Awake() { instance = this; }

    public Spanwer spawner;
    public Health health;

    void Satrt()
    {
        GetComponent<Healthit();

        StartCoroutine(WaveStartDelay());
    }

    IEnumerator WaveStartDelay()
    {
        //wait for x seconds
        yield return new WaitForSeconds(4f);
        //Start the enemy spawning
        GetComponent<Enemyspawn>().StartSpawning();
    }
}
