using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Math : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Bolas bola1;
    public Bolas bola2;
    public Bolas bola3;


    void operationNya()
    {
        int n1 = Random.Range(1, 100);
        int n2 = Random.Range(1, 100);

        string availableOperations = "+-*/";
        int operationIndex = Random.Range(0, availableOperations.Length);
        char operation = availableOperations[operationIndex];

        string opTEXT = n1.ToString() + operation + n2.ToString();
        int answer = 0;

        if (operation == '/')
        {	
            do
            {
                n1 = Random.Range(1, 100);
                n2 = Random.Range(1, 100);
                opTEXT = n1.ToString() + operation + n2.ToString();
                answer = (int)(n1 / n2);
            } while (n1 % n2 != 0);
        }
        else if (operation == '*')
        {
            do {
                n1 = Random.Range(1, 100);
                n2 = Random.Range(1, 100);
                opTEXT = n1.ToString() + operation + n2.ToString();
                answer = n1 * n2;
            } while (answer > 100);
        }
        else if (operation == '+')
        {
            answer = n1 + n2;
        }
        else if (operation == '-')
        {
            do
            {
                n1 = Random.Range(1, 100);
                n2 = Random.Range(1, 100);
                opTEXT = n1.ToString() + operation + n2.ToString();
                answer = n1 - n2;
            } while (answer < 0);
        }

        int wrongAnswer1 = answer + Random.Range(1, 10);
        int wrongAnswer2 = answer - Random.Range(1, 10);

        List<int> answers = new List<int>();
        answers.Add(answer);
        answers.Add(wrongAnswer1);
        answers.Add(wrongAnswer2);

        for (int i = 0; i < 3; i++)
        {
            int randomIndex = Random.Range(0, answers.Count);
            int randomAnswer = answers[randomIndex];
            answers.RemoveAt(randomIndex);

            if (i == 0)
            {
                bola1.respuesta = randomAnswer;
                bola1.isCorrect = randomAnswer == answer;
            }
            else if (i == 1)
            {
                bola2.respuesta = randomAnswer;
                bola2.isCorrect = randomAnswer == answer;
            }
            else if (i == 2)
            {
                bola3.respuesta = randomAnswer;
                bola3.isCorrect = randomAnswer == answer;
            }
        }

        GetComponent<TextMeshPro>().text = opTEXT;

    }



    void Start()
    {
        operationNya();
    }

    // Update is called once per frame
    void Update()
    {
        if (bola1.manImDead == true || bola2.manImDead == true || bola3.manImDead == true)
        {
            bola1.manImDead = false;
            bola2.manImDead = false;
            bola3.manImDead = false;
            operationNya();
            
        }
    }
}
