using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public GameObject paddle1, paddle2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GameObject instance = paddle1;
            instance.GetComponent<Rigidbody>().velocity = Vector3.forward * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            GameObject instance = paddle1;
            instance.GetComponent<Rigidbody>().velocity = Vector3.back * moveSpeed;
        }
        else
        {
            GameObject instance = paddle1;
            instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GameObject instance = paddle2;
            instance.GetComponent<Rigidbody>().velocity = Vector3.forward * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GameObject instance = paddle2;
            instance.GetComponent<Rigidbody>().velocity = Vector3.back * moveSpeed;
        }
        else
        {
            GameObject instance = paddle2;
            instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BallPrefab")
        {
            GetComponent<Rigidbody>().velocity = Vector3.Reflect(GetComponent<Rigidbody>().velocity, collision.contacts[0].normal); 
        }

    }
}
