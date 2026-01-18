using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 1.2f;

    public float minY = 1.0f;
    public float maxY = 4.0f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 0.5f, spawnInterval);
    }

    void SpawnCoin()
    {
        float y = Random.Range(minY, maxY);
        Vector3 pos = new Vector3(transform.position.x, y, 0f);
        Instantiate(coinPrefab, pos, Quaternion.identity);
    }
}
