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
    float t;
    // Use this for initialization
    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();

        originalColors = new Color[renderers.Length];

        for (int i = 0; i < renderers.Length; i++)
        {
            originalColors[i] = renderers[i].material.color;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            colorsFlipped = !colorsFlipped;
            t = 0;
        }

        if (colorsFlipped)
        {
            if (t < 1)
            {
                for (int i = 0; i < renderers.Length; i++)
                {
                    renderers[i].material.color = Color.Lerp(originalColors[i], flippedColor, t);
                }
                t += Time.deltaTime;

            }
        }
        else
        {
            if (t < 1)
            {
                for (int i = 0; i < renderers.Length; i++)
                {
                    renderers[i].material.color = Color.Lerp(flippedColor, originalColors[i], t);
                }
                t += Time.deltaTime;

            }
        }

        text.Input = t;
    }
}
