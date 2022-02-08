using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int p1score = 0;
    public int p2score = 0;
    
    public void p1scores()
    {
        p1score++;
        Debug.Log("P1 Scored!");
        Debug.Log("The score is " + p1score + " to " + p2score);
        if (p1score >= 11)
        {
            Debug.Log("P1 Wins!");
            p1score = 0;
            p2score = 0;
        } 
    }
    
    public void p2scores()
    {
        p2score++;
        Debug.Log("P2 Scored!");
        Debug.Log("The score is " + p1score + " to " + p2score);
        if (p2score >= 11)
        {
            Debug.Log("P2 Wins!");
            p1score = 0;
            p2score = 0;
        } 
    }

    void OnTriggerEnter(Collider collider)
    {
        if (name == "Right Goal" && collider.name == "BallPrefab" || collider.name == "BallPrefab(Clone)")
        {
            p1scores();
        }

        if (name == "Left Goal" && collider.name == "BallPrefab" || collider.name == "BallPrefab(Clone)")
        {
            p2scores();
        }
    }
}
