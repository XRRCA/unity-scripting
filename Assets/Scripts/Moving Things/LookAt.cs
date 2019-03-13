using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform target;
	
    public enum LookType
    {
        LookAt, LookRotation, DontLook
    }

    public LookType method;
	// Update is called once per frame
	void Update () {
        if(method == LookType.LookAt)
            transform.LookAt(target);
        else if (method == LookType.LookRotation)
            transform.rotation = Quaternion.LookRotation(transform.position - target.position);
	}
}
