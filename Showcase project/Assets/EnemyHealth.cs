using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    public GameObject[] itemDrops;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "damage")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }

        }
    }


    private void ItemDrop()
    {
        for (int i = 0; i < itemDrops.Length; i++)
        {
            Instantiate(itemDrops[i], transform.position, Quaternion.identity);
        }
    }
}