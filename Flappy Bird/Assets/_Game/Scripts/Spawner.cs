using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] float time = 2f;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), time, time);
    }


    void Update()
    {
        
    }

    private void Spawn()
    {
        GameObject newPipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        newPipe.transform.position += new Vector3();
    }
}
