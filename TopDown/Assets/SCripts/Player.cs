using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float moveSpeed = 3f;
    Rigidbody2D rb2d;
    public GameObject zombie;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();


    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);

        //Vector Math stuff ...
        Vector2 lookDir = mousePos - rb2d.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb2d.rotation = angle;
    }

    
    Vector2 movement;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = Camera.main.ScreenPointToRay(Input.mousePosition).origin;

        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject[] gameObjects;
            gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

            if (gameObjects.Length != 0)
            {
                foreach (var item in gameObjects)
                {
                    Destroy(item);
                }
            }
        }

    }
    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }


}
