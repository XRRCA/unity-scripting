using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class FloatToText : MonoBehaviour {
    Text text;

    float value;

    public float Input
    {
        get
        {
            return value;
        }

        set
        {
            this.value = value;
            text.text = value.ToString("#.000");
        }
    }

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
}
