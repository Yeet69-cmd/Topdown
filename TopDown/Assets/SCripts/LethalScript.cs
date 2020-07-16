using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LethalScript : MonoBehaviour
{

    public float damage;
    public string enemyTag;
    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.name);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == enemyTag)
        {
            other.gameObject.GetComponent<HealthManger>().TakeDamage(damage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
