using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class HealthPack : MonoBehaviour
{
    [SerializeField] GameObject healthPackPrefab;
    [SerializeField] float minSpawnTime = 10f;
    [SerializeField] float maxSpawnTime = 15f;

    Vector2 screenBounds;
    Vector2 spawnPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnHealthPack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnHealthPack()
    {
        float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        spawnPos = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
        Instantiate(healthPackPrefab, spawnPos, transform.rotation);
        Invoke("SpawnHealthPack", spawnTime);
    }
}
