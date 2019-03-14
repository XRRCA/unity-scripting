using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningExample : MonoBehaviour {

    public Transform prefab;

    public float timeBetweenSpawns = 5;
    public float lifeLength = 10f;

    public int x = 10, y = 10, numberToCreate = 15;

	// Use this for initialization
	void Start () {
        StartCoroutine(GenerateAndDestroy(timeBetweenSpawns));
	}
	
	// Update is called once per frame
	IEnumerator GenerateAndDestroy (float t) {
        while (true)
        {
            yield return new WaitForSeconds(t);
            // TODO Use a LOOP to Instantiate 15 prefabs
            // Usful bits:
            // var position = transform.position + new Vector3(Random.Range(-x, x), 10, Random.Range(-y, y));
        }
        
    }
}
