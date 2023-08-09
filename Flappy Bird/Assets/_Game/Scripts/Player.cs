using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 axis;
    [SerializeField] float gravity = -9f;
    
    void Start()
    {
        
    }

  
    void Update()
    {
        axis.y += gravity * Time.deltaTime;
        transform.position += axis * Time.deltaTime;
    }
}
