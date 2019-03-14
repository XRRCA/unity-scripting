using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipWorldColors : MonoBehaviour
{
    Renderer[] renderers;
    Color[] originalColors;

    public Color flippedColor;
    public FloatToText text;

    bool colorsFlipped;
    float lerpTime;

    // Use this for initialization
    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();

        originalColors = new Color[renderers.Length];

        // TODO Store colors on materials in renderers in the originalColors array

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            colorsFlipped = !colorsFlipped;
        }

        // TODO Make an IF ELSE statement to Lerp a Color up or down, 
        // and set each renderer's material to that color. You will need to: 
        // Increment/decrement time, 
        // Iterate an array
        // Use the Color.Lerp(colorA, colorB, lerpTime)

        // Update the GUI with current lerp time.
        text.Input = lerpTime;
    }
}
