using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{

    string[] usernames = { "ada", "tesla", "hannibal" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(usernames[0]);
        Debug.Log(usernames[1]);
        Debug.Log(usernames[2]);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
