using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;

    float minimumHeight = -17.4f;
    float maximumHeight = -12.9f;

    // Start is called before the first frame update
    void Start()
    {
    InvokeRepeating("SpawnPipes", 1.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(1.05F, Random.Range(minimumHeight, maximumHeight)), Quaternion.identity);
    }
}
