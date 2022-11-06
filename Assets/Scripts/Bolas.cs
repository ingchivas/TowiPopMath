using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bolas : MonoBehaviour
{
    public string color;
    public bool isCorrect;
    public bool manImDead = false;
    public float speed = 1.0f;

    public bool hitsPlayer = false;

    public PlayerController player;

    public Math math;

    public int respuesta=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * (-1));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            hitsPlayer = true;
            // manImDead = true;
        }
    }
}

