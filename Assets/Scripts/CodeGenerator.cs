using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeGenerator : MonoBehaviour
{
    
    string[] SPACE = { "S", "P", "A", "C", "E" };
    
    void Start()
    {
        
    }

    
    void Update()
    {
        int randomLetter = (int)Random.Range(0f, 5f);
        int randomInt = (int)Random.Range(1f, 76f);
        Debug.Log(SPACE[randomLetter]+randomInt);
    }
}
