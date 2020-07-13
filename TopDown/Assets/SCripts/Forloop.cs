using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forloop : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Iteration " + i);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}

