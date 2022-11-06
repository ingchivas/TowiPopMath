using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    // static private int score = 0;

    public float speed = 1.0f;

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
        if (other.CompareTag("Bolas"))
        {
                Bolas bola = other.GetComponent<Bolas>();
                bola.manImDead = true;
            if (other.GetComponent<Bolas>().isCorrect)
            {
                // score++;
                // Debug.Log("Le diste a la bola correcta: " + score);
                Destroy(other.gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        
    }

}