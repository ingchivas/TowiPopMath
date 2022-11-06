using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        // If there is no other music playing
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            // Destroy this music
            Destroy(gameObject);
        }
        // If there is music playing
        else
        {
            // Don't destroy this music
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        Awake();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if only one audio object exists
    }
}
