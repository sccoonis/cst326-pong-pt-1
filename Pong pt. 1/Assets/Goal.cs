using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject ScoreManager;

    void OnTriggerEnter(Collider collider)
    {
        if (this.name == "Right Goal" && collider.name == "BallPrefab" || collider.name == "BallPrefab(Clone)")
        {
            ScoreManager.GetComponent<ScoreManager>().p1scores();
        }

        if (this.name == "Left Goal" && collider.name == "BallPrefab" || collider.name == "BallPrefab(Clone)")
        {
            ScoreManager.GetComponent<ScoreManager>().p2scores();
        }    
    }
}
