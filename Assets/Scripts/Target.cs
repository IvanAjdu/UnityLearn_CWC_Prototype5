using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;

    private float minForce = 11f;
    private float maxForce = 17f;
    private float torqueRange = 10;
    private float xSpawnRange = 6f;
    private float ySpawnPos = -1f;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque());

        transform.position = RandomSpawnPos();
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos);
    }

    float RandomTorque()
    {
        return Random.Range(-torqueRange, torqueRange);
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minForce, maxForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
