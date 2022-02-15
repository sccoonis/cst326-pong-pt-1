using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "BallPrefab" || collider.name == "BallPrefab(Clone)")
        {
            int rand = Random.Range(0, 2);

            if (rand == 0)
            {
                collider.GetComponent<Rigidbody>().transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }
            else
            {
                collider.GetComponent<Rigidbody>().transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            }

        }
    }
}
