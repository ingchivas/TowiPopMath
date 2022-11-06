using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    // public PlayerController player;

    public Bolas bola1;
    public Bolas bola2;
    public Bolas bola3;
    public Score a;


    public static int livesP = 3;

    public void RemoveLife()
    {
        livesP--;
       
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (bola1.manImDead == true && bola1.isCorrect == false)
        {
            RemoveLife();
        }
        if (bola2.manImDead == true && bola2.isCorrect == false)
        {
            RemoveLife();
        }
        if (bola3.manImDead == true && bola3.isCorrect == false)
        {
            RemoveLife();
        }
        if (bola1.hitsPlayer == true || bola2.hitsPlayer == true || bola3.hitsPlayer == true)
        {
            RemoveLife();
        }

         GetComponent<TextMeshPro>().text = livesP.ToString();

         if (livesP == 0)
         {
            livesP = 3;
            a.ResetScore();
            SceneManager.LoadScene("Perdiste", LoadSceneMode.Single);
            
         }
    }
}
