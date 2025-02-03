using UnityEngine;

public class RoadScript : MonoBehaviour
{

    public GameObject RoadSpawner;

    private float _currentTimer;
    public float spawnTimer = 1.7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _currentTimer += Time.deltaTime;
        if (_currentTimer >= spawnTimer)
        {
            SpawnRoad();
            _currentTimer = 0.0f;
        }
    }

    void SpawnRoad()
    {
        Vector3 spawnPosition = new Vector3(0.0f, 0.0f, 0.0f);
        Instantiate(RoadSpawner, spawnPosition, Quaternion.identity);
    }
}
