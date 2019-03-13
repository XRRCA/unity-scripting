using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGameObjects : MonoBehaviour {
    public GameObject alternateTrees;

	private void OnTriggerEnter(Collider other)
	{
        if ( other.tag == "Player"){
            alternateTrees.SetActive(true);
        }
	}

	private void OnTriggerExit(Collider other)
	{
        if (other.tag == "Player")
        {
            alternateTrees.SetActive(false);
        }
	}
}
