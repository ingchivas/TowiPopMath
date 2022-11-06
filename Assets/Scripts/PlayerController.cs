using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;

    public float speed = 10.0f;

    public float xRange = 15.0f;

    // public int lives = 3;

    // public void RemoveLife()
    // {
    //     lives--;
    // }

    public GameObject projectilPrefab;

    private int projectilCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ahoot proyectile
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (projectilCount < 3)
            {
                Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
                projectilCount++;
            }

        }


        horizontalInput = Input.GetAxis("Horizontal");

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    // If esc is pressed, the game will close

        


}