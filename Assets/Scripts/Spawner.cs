using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnDelay;
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    [SerializeField] Cube _cubePrefab;

    public float SpawnDelay => _spawnDelay;
    public float Speed => _speed;
    public float Distance => _distance;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnCube");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnCube()
    {
        Cube cube = Instantiate(_cubePrefab);
        cube.Init(_speed, _distance);

        yield return new WaitForSeconds(_spawnDelay);

        StartCoroutine("SpawnCube");
    }

    public void SetSpawnDelay(float newSpawnDelay)
    {
        _spawnDelay = newSpawnDelay;
    }

    public void SetSpeed(float newSpeed)
    {
        _speed = newSpeed;
    }

    public void SetDistance(float newDistance)
    {
        _distance = newDistance;
    }



}
