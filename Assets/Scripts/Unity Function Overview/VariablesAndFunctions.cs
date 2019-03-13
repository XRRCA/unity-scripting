using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour 
{ // <- Blocks of code are enclosed by curly brackets: { }

    // VARIABLES

    int myPinNumber = 1234;
    float timeToMakeDecision = 495.5f;
    bool tomIsALiar = true;
    bool isFalse, isNotTrue; // Un valued default to false;
    int thisIsZero;
    float thisIsAlsoZero;
    string coreLifeSkill = "flattery";

    // FUNCTIONS

	// Use this for initialization
	void Start () {
        Debug.Log("My pin number: " + myPinNumber);
        Debug.Log("Double my pin number: " + MultiplyByTwo(myPinNumber));
	}

    int MultiplyByTwo(int number)
    {
        int ret;
        ret = number * 2;
        return ret;
    }
}
