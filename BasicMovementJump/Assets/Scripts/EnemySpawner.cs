using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] spawnLocations;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemies();   
    }

    public void spawnEnemies()
    {
        int randomIndex;
        GameObject spawnedPrefab;
        for(int i = 0; i < spawnLocations.Length; i++)
        {
            randomIndex = Random.Range(0, enemies.Length);

            spawnedPrefab = Instantiate(enemies[randomIndex].gameObject);

            spawnedPrefab.transform.position = new Vector2(spawnLocations[i].transform.position.x, spawnLocations[i].transform.position.y);
        }
    }
}
