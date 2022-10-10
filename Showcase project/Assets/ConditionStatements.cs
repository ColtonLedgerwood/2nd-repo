using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionStatements : MonoBehaviour
{
    int level = 3;
    [SerializeField]
    public int xp = 3;
    [SerializeField]
    public int LevelUpXp = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (xp >= LevelUpXp)
        {
            level++;
            xp = xp - LevelUpXp;
            LevelUpXp += 10;
            Debug.Log("DING! Congratulations, you've reached level " + level);
        }
    }
}

