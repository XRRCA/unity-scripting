using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
    
    // For loop

    int numEnemies = 3;

    void ForLoop()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }

    // While Loop

    int cupsInTheSink = 4;

    void WhileLoop()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }

    // Do While Loop
    void DoWhileLoop()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);
    }

    // For each loop

    void ForEachLoop()
    {
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print(item);
        }
    }

	private IEnumerator Start()
	{
        ForLoop();

        yield return new WaitForSeconds(5f);

        WhileLoop();

        yield return new WaitForSeconds(5f);

        DoWhileLoop();

        yield return new WaitForSeconds(5f);

        ForEachLoop();
	}
}
