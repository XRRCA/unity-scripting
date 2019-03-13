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

        if (menuActive && !menu)
        {
            var pos = transform.position + transform.forward * distance;
            menu = Instantiate(menuPrefab, pos, Quaternion.LookRotation(-transform.forward));
        }
        else if (!menuActive && menu)
        {
            Destroy(menu);
        }
	}
}
