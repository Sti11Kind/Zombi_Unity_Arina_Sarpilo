using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // Move here coin prefab
    public Transform platform; // move here plane
    public float spawnInterval = 3f; // how often coins appears
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnCoin", 2f, spawnInterval);
    }

    void SpawnCoin()
    {
        // random scaling left-right and back-forth
        float rx = Random.Range(-3f, 3f);
        float rz = Random.Range(-8f, 8f);
        
        // Platform Center with scatter
        Vector3 spawnPos = platform.position + new Vector3(rx, 1.5f, rz);
        
        // Creat a coin
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
