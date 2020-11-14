using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject slimePrefab;
    public float timeBetweenWaves = 1f;
    float timeToSpawn = 2f;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnSlimes();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void SpawnSlimes()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(slimePrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}