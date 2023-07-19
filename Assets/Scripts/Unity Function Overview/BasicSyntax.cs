// using statements gather things needed for that script in libraries, APIs etc.
using UnityEngine;

public class BasicSyntax : MonoBehaviour 
{ // <- Blocks of code are enclosed by curly brackets: { }

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Start()
    {
        // Comment for a line below
        Debug.Log(transform.position.x);

         /*Block Comment
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }*/
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    // IF statement example
    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}
