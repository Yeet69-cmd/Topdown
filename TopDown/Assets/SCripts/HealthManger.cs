using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManger : MonoBehaviour
{

      
    public Image healthbar; 
 
    float health;
    public float maxHealth;
    public Behaviour[] disableOnDeath;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public  void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
        healthbar.fillAmount = health / maxHealth;
    }
    void Die()
    {
        //Disable all the components inside the disableOnDeath array that you will assign from the inspector
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
        }
    }

}
