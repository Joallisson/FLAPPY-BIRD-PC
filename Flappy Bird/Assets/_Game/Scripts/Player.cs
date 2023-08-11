using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 axis;
    [SerializeField] float gravity, force;
    private GameManager gameManager;
    
    void Start()
    {
        gravity = -9f;
        force = 5f;
        gameManager = FindObjectOfType<GameManager>();

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacles"))
        {
            gameManager.GameOver();
        }
    }


}
