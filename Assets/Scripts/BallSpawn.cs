using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    public GameObject ball4;
    
    void Start()
    {
        for (int i=0; i<19; i++)
        {
            Instantiate(ball1, transform.position, Quaternion.identity);
            Instantiate(ball2, transform.position, Quaternion.identity);
            Instantiate(ball3, transform.position, Quaternion.identity);
            Instantiate(ball4, transform.position, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
