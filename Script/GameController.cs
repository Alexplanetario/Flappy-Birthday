using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float SpawnTimer;
    float SpawnRate = 3f;
    public GameObject tubo;
    public static bool GameOver;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameOver)
        {
            SpawnTimer += Time.deltaTime;
            if (SpawnTimer >= SpawnRate)
            {
                SpawnTimer -= SpawnRate;
                Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f));
                Instantiate(tubo, spawnPos, Quaternion.identity);

            }

        }

            
    }
}
