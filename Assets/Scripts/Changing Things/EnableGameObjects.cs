using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGameObjects : MonoBehaviour {
    public GameObject alternateTrees;

	private void OnTriggerEnter(Collider other)
	{
        // TODO Switch on trees using SetActive if the "other" has a Player tag
	}

	private void OnTriggerExit(Collider other)
	{
        // TODO Switch on trees using SetActive if the "other" has a Player tag
	}
}
