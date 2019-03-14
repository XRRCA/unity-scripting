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
            lerpTime = 0;
        }

        // TODO Make an IF ELSE statement to Lerp a Color up or down, 
        // and set each renderer's material to that color. You will need to: 
        // Increment time, 
        // Use the Color.Lerp(colorA, colorB, lerpTime)

        if (colorsFlipped)
        {
            if (lerpTime < 1)
            {
                for (int i = 0; i < renderers.Length; i++)
                {
                    renderers[i].material.color = Color.Lerp(originalColors[i], flippedColor, lerpTime);
                }
                lerpTime += Time.deltaTime;

            }
        }
        else
        {
            if (lerpTime < 1)
            {
                for (int i = 0; i < renderers.Length; i++)
                {
                    renderers[i].material.color = Color.Lerp(flippedColor, originalColors[i], lerpTime);
                }
                lerpTime += Time.deltaTime;

            }
        }

        text.Input = lerpTime;
    }
}
