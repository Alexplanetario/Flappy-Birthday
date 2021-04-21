
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float SpawnTimerTubo;
    float SpawnRateTubo = 3f;

    float SpawnTimerTorta;
    float SpawnRateTorta = 5f;

    public GameObject Tubo;
    public GameObject Torta;

    public static bool GameOver;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameOver)
        {
            SpawnTimerTubo += Time.deltaTime;
            if (SpawnTimerTubo >= SpawnRateTubo)
            {
                SpawnTimerTubo -= SpawnRateTubo;
                Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f));
                Instantiate(Tubo, spawnPos, Quaternion.identity);

            }
            if (SpawnTimerTorta >= SpawnRateTorta)
            {
                SpawnTimerTorta -= SpawnRateTorta;
                Vector2 spawnPosTorta = new Vector2(2f,1f);
                Instantiate(Torta, spawnPosTorta, Quaternion.identity);

            }

        }


    }
}