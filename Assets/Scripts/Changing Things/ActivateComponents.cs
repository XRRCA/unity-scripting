using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateComponents : MonoBehaviour
{
    Renderer[] mountains;

    bool mountainsVisible = true;
    bool processComplete = true;
    // Use this for initialization
    void Start()
    {
        mountains = GetComponentsInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            mountainsVisible = !mountainsVisible;
            processComplete = false;
        }

        if (!processComplete)
        {
            for (int i = 0; i < mountains.Length; i++)
            {
                mountains[i].enabled = mountainsVisible;
            }
        }

    }
}
