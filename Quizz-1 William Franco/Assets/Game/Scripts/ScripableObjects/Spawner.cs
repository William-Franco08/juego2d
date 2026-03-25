using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject apple;
    public GameObject orange;
    public GameObject kiwi;
    public GameObject banana;

    private int appleAmount = 3;
    private int orangeAmount = 2;
    private int kiwiAmount = 5;
    private int bananaAmount = 1;

    public float spawnRadius = 1f;
    public LayerMask obstacleLayer;  
    void Start()
    {
        SpawnItems();
    }

    void SpawnItems()
    {
        for (int i = 0; i < appleAmount; i++)
        {
            Instantiate(apple, GetValidPosition(), Quaternion.identity);
        }

        for (int i = 0; i < orangeAmount; i++)
        {
            Instantiate(orange, GetValidPosition(), Quaternion.identity);
        }

        for (int i = 0; i < kiwiAmount; i++)
        {
            Instantiate(kiwi, GetValidPosition(), Quaternion.identity);
        }

        for (int i = 0; i < bananaAmount; i++)
        {
            Instantiate(banana, GetValidPosition(), Quaternion.identity);
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