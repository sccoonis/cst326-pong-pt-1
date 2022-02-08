using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallPrefab : MonoBehaviour
{
    public float speed = 600.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(1,0,1) * -speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
