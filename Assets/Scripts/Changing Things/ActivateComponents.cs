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
            // TODO Set variables to start the next logic phase
        }

        // TODO Make an IF and a LOOP to switch on or off all the mountain renderers
        // IF
            // LOOP

    }
}
