using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// World space menu example.
/// </summary>
public class MenuExample : MonoBehaviour {
    public GameObject menuPrefab;

    bool menuActive;
    float distance = 2;

    GameObject menu;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.M))
        {
            menuActive = !menuActive;
        }

        // TODO Switch on and off the menu depending on input
        // Do button switching IF 
        // IF ON AND NOMENU - MAKE MENU
            // menuPos = playerPosition + playerTransform.forwardDirection * distance
            // Instantiate 
        // ELSEIF OFF AND MENU - DESTROY MENU

	}
}
