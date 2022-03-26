using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    [SerializeField] Spawner _spawner;

    [SerializeField] InputField _spawnDelayInput;
    [SerializeField] InputField _speedInput;
    [SerializeField] InputField _distanceInput;

    // Start is called before the first frame update
    void Start()
    {
        _spawnDelayInput.text = _spawner.SpawnDelay.ToString();
        _speedInput.text = _spawner.Speed.ToString();
        _distanceInput.text = _spawner.Distance.ToString();

        _spawnDelayInput.onValueChanged.AddListener((value) => SetSpawnDelay(value));
        _speedInput.onValueChanged.AddListener((value) => SetSpeed(value));
        _distanceInput.onValueChanged.AddListener((value) => SetDistance(value));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetSpawnDelay(string newValue)
    {
        float newSpawnDelay;

        if (! float.TryParse(newValue, out newSpawnDelay))
        {
            return;
        }

        if (newSpawnDelay < 0)
        {
            _spawnDelayInput.text = 0.ToString();
            return;
        }

        _spawner.SetSpawnDelay(newSpawnDelay);
    }

    private void SetSpeed(string newValue)
    {
        float newSpeed;

        if (!float.TryParse(newValue, out newSpeed))
        {
            return;
        }

        if (newSpeed < 0)
        {
            _speedInput.text = 0.ToString();
            return;
        }

        _spawner.SetSpeed(newSpeed);
    }

    private void SetDistance(string newValue)
    {
        float newDistance;

        if (!float.TryParse(newValue, out newDistance))
        {
            return;
        }

        if (newDistance < 0)
        {
            _distanceInput.text = 0.ToString();
            return;
        }

        _spawner.SetDistance(newDistance);
    }
}
