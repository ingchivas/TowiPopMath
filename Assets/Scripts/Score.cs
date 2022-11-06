using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update

    static public int score = 0;

    public Bolas bola1;
    public Bolas bola2;
    public Bolas bola3;

    public void AddScore()
    {
        score++;
    }


    public void ResetScore()
    {
        score = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bola1.manImDead == true && bola1.isCorrect == true)
        {
            AddScore();
        }
        if (bola2.manImDead == true && bola2.isCorrect == true)
        {
            AddScore();
        }
        if (bola3.manImDead == true && bola3.isCorrect == true)
        {
            AddScore();
        }
        GetComponent<TextMeshPro>().text = score.ToString();
    }
}
