using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed, leftBorder;

    void Start()
    {
        speed = -2f;
        leftBorder = Camera.main.ScreenToViewportPoint(Vector3.zero).x - 10;
    }

    
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (transform.position.x <= leftBorder)
        {
            Destroy(gameObject);
        }
    }
}
