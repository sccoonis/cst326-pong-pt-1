using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float moveSpeed = 20.0f;
    public GameObject paddle1, paddle2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GameObject instance = paddle1;
            instance.GetComponent<Rigidbody>().velocity += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GameObject instance = paddle1;
            instance.GetComponent<Rigidbody>().velocity += Vector3.back * moveSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GameObject instance = paddle2;
            instance.GetComponent<Rigidbody>().velocity += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GameObject instance = paddle2;
            instance.GetComponent<Rigidbody>().velocity += Vector3.back * moveSpeed * Time.deltaTime;
        }
    }
}
