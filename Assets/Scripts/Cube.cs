using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    private Vector3 _startPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, _startPoint) > _distance)
        {
            Destroy(gameObject);
        }
    }

    public void Init(float speed, float distance)
    {
        _speed = speed;
        _distance = distance;

        _startPoint = transform.position;
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }

    public void SetDistance(float distance)
    {
        _distance = distance;
    }
}
