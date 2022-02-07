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
        } 
    }
    
    void OnTriggerEnter(Collider collider)
    {
        if (name == "Right Goal")
        {
            p1scores();
        }

        if (name == "Left Goal")
        {
            p2scores();
        }
    }
}
