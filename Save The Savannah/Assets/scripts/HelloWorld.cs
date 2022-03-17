//Hello World
//Author: Robert Bulmer
//Date 10/03/22

//Libraries used
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public string message = "Hello World";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Goodbye");
    }
}
