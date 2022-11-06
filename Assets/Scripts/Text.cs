using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
        public Bolas bola;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Bolas.
        GetComponent<TextMeshPro>().text = bola.respuesta.ToString();

    }
}
