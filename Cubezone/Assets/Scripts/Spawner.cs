using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] spawningPatterns;

    [Space]


    [Header("Timings")]
    public float startTimeBtwSpawn;
    private float timeBtwSpawn;
    public float decreaseTime;
    [Range(0.5f,2f)]
    public float minSpawnTime;

    [Space]
    [Header("Distances")]
    [Range(100f, 1000f)]
    public float distanceFromPlayer;

    public Transform playerTransform;
    private Vector3 spawnerPosition;

    private void UpdateSpawnerPosition()
    {
        spawnerPosition = new Vector3(0, 0, 60);
        spawnerPosition.z += playerTransform.position.z;
        transform.position = spawnerPosition;
    }

    void Update()
    {
        UpdateSpawnerPosition();

        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, spawningPatterns.Length);
            Instantiate(spawningPatterns[rand], transform.position, Quaternion.identity);

            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minSpawnTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

        DespawnObstaclePatterns();
    }

    private GameObject[] spawnedPatterns;
    private GameObject[] spawnedObstacles;
    private void DespawnObstaclePatterns()
    {
        spawnedPatterns = GameObject.FindGameObjectsWithTag("ObstaclePattern");
        spawnedObstacles = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach (GameObject obstacle in spawnedObstacles)
        {
            if (obstacle.transform.position.z < playerTransform.position.z)
            {
                Destroy(obstacle, 0.5f);
            }
        }

        foreach (GameObject pattern in spawnedPatterns)
        {
            if (pattern.transform.position.z < playerTransform.position.z)
            {
                Destroy(pattern, 0.5f);
            }
        }
    }
}
