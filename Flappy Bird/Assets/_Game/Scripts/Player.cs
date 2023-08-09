using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 axis;
    [SerializeField] float gravity, force;
    
    void Start()
    {
        gravity = -9f;
        force = 5f;
    }

  
    void Update()
    {
        axis.y += gravity * Time.deltaTime;
        transform.position += axis * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            axis = Vector2.up * force;
        }
    }
}
