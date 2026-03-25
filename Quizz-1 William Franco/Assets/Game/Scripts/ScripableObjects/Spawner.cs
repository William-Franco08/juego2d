using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject orangePrefab;

    public int appleAmount = 3;
    public int orangeAmount = 2;

    public float spawnRadius = 0.5f;
    public LayerMask obstacleLayer;  
    void Start()
    {
        SpawnItems();
    }

    void SpawnItems()
    {
        for (int i = 0; i < appleAmount; i++)
        {
            Instantiate(applePrefab, GetValidPosition(), Quaternion.identity);
        }

        for (int i = 0; i < orangeAmount; i++)
        {
            Instantiate(orangePrefab, GetValidPosition(), Quaternion.identity);
        }
    }

    Vector3 GetValidPosition()
    {
        Vector3 pos;
        int maxAttempts = 20; 

        do
        {
            pos = new Vector3(
                Random.Range(-5f, 5f),
                Random.Range(-3f, 3f),
                0f
            );

            maxAttempts--;

        } while (Physics2D.OverlapCircle(pos, spawnRadius, obstacleLayer) && maxAttempts > 0);

        return pos;
    }
}