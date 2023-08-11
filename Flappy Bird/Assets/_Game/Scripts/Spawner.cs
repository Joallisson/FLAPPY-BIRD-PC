using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] float time, minY, maxY;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), time, time);
        time = 2f;
        minY = -2f;
        maxY = 2f;
    }


    void Update()
    {
        
    }

    private void Spawn()
    {
        GameObject newPipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        newPipe.transform.position += new Vector3(0, Random.Range(minY, maxY));
    }
}
