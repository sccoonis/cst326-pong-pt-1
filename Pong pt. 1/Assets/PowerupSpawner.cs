using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public Transform[] spawnTransforms;
    
    // Start is called before the first frame update
    void Start()
    {
        Transform randoTransform = spawnTransforms[Random.Range(0,spawnTransforms.Length)];
        GameObject instance = Instantiate(powerupPrefab);
        instance.transform.position = randoTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("powerupPrefab") != null)
        {
            Debug.Log("making powerup");
            Start();
        }
    }
}
