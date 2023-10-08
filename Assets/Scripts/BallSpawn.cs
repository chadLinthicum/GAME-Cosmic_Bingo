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
            //This will spawn the prefabs as a child to the game object it is attached to
            Instantiate(ball1, transform);
            Instantiate(ball2, transform);
            Instantiate(ball3, transform);
            Instantiate(ball4, transform);
        }
    }

    void Update()
    {
        
    }
}
