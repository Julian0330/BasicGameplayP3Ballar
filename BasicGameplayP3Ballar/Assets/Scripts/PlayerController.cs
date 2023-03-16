using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float verticleInput;
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 20;
    public float yRange = 5;

    public GameObject projectilePrefab;
    public float zMin;
    public float zMax;
    public float verticalInput;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from player.
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        //Keeps the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }



        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if (transform.position.y > xRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        {
            verticleInput = Input.GetAxis("Verticle");
            transform.Translate(Vector3.up * verticleInput * Time.deltaTime * speed);
        }
    }
}

